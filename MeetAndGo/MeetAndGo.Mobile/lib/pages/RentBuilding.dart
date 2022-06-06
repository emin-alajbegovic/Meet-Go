import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlUserAccount.dart';
import 'package:meet_go_mobile/pages/BuildingDetails.dart';

import '../models/mdlBuilding.dart';
import '../services/APIService.dart';
import '../services/Payment.dart';

class RentBuilding extends StatefulWidget {
  final mdlBuilding product;

  const RentBuilding({Key? key, required this.product}) : super(key: key);

  @override
  State<RentBuilding> createState() => _RentBuildingState();
}

var loggedUser;

int getDataDiffence(DateTime begin, DateTime end) {
  var difference = end.difference(begin);
  return difference.inDays;
}

var beginRentalDate = DateTime(2022, 6, 5);
var endRentalDate = DateTime(2022, 8, 8);

class _RentBuildingState extends State<RentBuilding> {
  @override
  Widget build(BuildContext context) {
    var dateDiff = getDataDiffence(beginRentalDate, endRentalDate);
    var sumController = dateDiff * widget.product.price;

    void payWithCard({required int amount}) async {
      var user = await APIService.GetByUsername('User', APIService.username);
      loggedUser = user!.map((e) => mdlUserAccount.fromJson(e)).first;
      var response = await StripeService.payWithNewCard(
          amount: amount.toString(), currency: 'BAM');
      final snackBar;
      if (response.message == 'Transaction cancelled') {
        snackBar = SnackBar(
          duration:
              Duration(milliseconds: response.success == false ? 1200 : 3000),
          content: Text(response.success == true
              ? response.message
              : 'Transaction canceled'),
        );
      } else {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(
            content: Row(
              children: [
                CircularProgressIndicator(),
                Container(
                    margin: EdgeInsets.only(left: 15),
                    child: Text("Please wait...")),
              ],
            ),
            duration: Duration(seconds: 5),
          ),
        );
        snackBar = SnackBar(
          duration:
              Duration(milliseconds: response.success == false ? 1200 : 3000),
          content: Text(response.success == true
              ? response.message
              : 'Transaction done'),
        );
        Map<String, dynamic> queryParams = {
          'buildingId': widget.product.buildingId,
          'userId': loggedUser.userId,
          'beginRentalDate': '2022-06-02T21:59:51.891',
          'endRentalDate': '2022-08-02T21:59:51.891',
          'rented': true,
          'days': dateDiff,
          'price': amount
        };
        var result = await APIService.Post('RentedBuilding', queryParams);
      }
      Navigator.of(context)
          .pushReplacementNamed('/home');
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
            content: Text('Building rented!')),
      );
    }

    StripeService.init();
    return Scaffold(
      appBar: AppBar(
        title: Text('Rent building'),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text(
              'Price per day: ' + widget.product.price.toString() + '€',
              style: TextStyle(
                  color: Colors.lightGreen.withOpacity(1.0),
                  fontSize: 17,
                  fontWeight: FontWeight.bold),
            ),
            Text(
              '${beginRentalDate.year}/${beginRentalDate.month}/${beginRentalDate.day}',
              style: TextStyle(fontSize: 20),
            ),
            ElevatedButton(
                child: Text('Select begin date'),
                onPressed: () async {
                  DateTime? newBeginRentalDate = await showDatePicker(
                      context: context,
                      initialDate: beginRentalDate,
                      firstDate: DateTime(1900),
                      lastDate: DateTime(2100));
                  if (newBeginRentalDate == null) return;

                  setState(() => beginRentalDate = newBeginRentalDate);
                }),
            Text(
              '${endRentalDate.year}/${endRentalDate.month}/${endRentalDate.day}',
              style: TextStyle(fontSize: 20),
            ),
            ElevatedButton(
              child: Text('Select end date'),
              onPressed: () async {
                DateTime? newEndRentalDate = await showDatePicker(
                    context: context,
                    initialDate: endRentalDate,
                    firstDate: DateTime(1900),
                    lastDate: DateTime(2100));
                if (newEndRentalDate == null) return;

                setState(() => endRentalDate = newEndRentalDate);
              },
            ),
            Text(
              'Total price: ' + sumController.toString() + '€',
              style: TextStyle(
                  color: Colors.lightBlue.withOpacity(1.0),
                  fontSize: 23,
                  fontWeight: FontWeight.bold),
            ),
            TextButton(
              child: Text('Cancel'),
              onPressed: () => Navigator.pop(context),
            ),
            TextButton(
              child: Text('Pay with card'),
              onPressed: () {
                payWithCard(amount: sumController);
              },
            ),
          ],
        ),
      ),
    );
  }
}
