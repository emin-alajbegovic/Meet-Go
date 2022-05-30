import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlOffice.dart';
import 'package:meet_go_mobile/models/mdlUserAccount.dart';
import '../services/APIService.dart';

class RentOffice extends StatefulWidget {
  final mdlOffice product;

  const RentOffice({Key? key, required this.product}) : super(key: key);

  @override
  State<RentOffice> createState() => _RentOfficeState();
}

var loggedUser;

void payWithCard() async {
  var user = await APIService.GetByUsername('User', APIService.username);
  loggedUser = user!.map((e) => mdlUserAccount.fromJson(e)).first;

  Map<String, dynamic> queryParams = {
    'officeId': 2,
    'userId': loggedUser.userId,
    'beginRentalDate': '2022-05-25T17:03:01.645Z',
    'endRentalDate': '2023-05-25T17:03:01.645Z',
    'rented': true,
    'days': 2,
    'price': 22
  };
  var result = await APIService.Post('RentedOffice', queryParams);
}

int getDataDiffence(DateTime begin, DateTime end) {
  var difference = end.difference(begin);
  return difference.inDays;
}
var beginRentalDate = DateTime(2022, 6, 5);
var endRentalDate = DateTime(2022, 8, 8);

class _RentOfficeState extends State<RentOffice> {
  @override
  Widget build(BuildContext context) {
    var dateDiff=getDataDiffence(beginRentalDate, endRentalDate);
    var sumController=dateDiff*widget.product.price;
    return Scaffold(
      appBar: AppBar(
        title: Text('Rent office'),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text(
              'Price per day: ' +
                  widget.product.price.toString() +
                  '€',
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
                  DateTime? newBeginRentalDate =
                  await showDatePicker(
                      context: context,
                      initialDate: beginRentalDate,
                      firstDate: DateTime(1900),
                      lastDate: DateTime(2100));
                  if (newBeginRentalDate == null) return;

                  setState(() =>
                  beginRentalDate = newBeginRentalDate);
                  print(beginRentalDate);
                }),
            Text(
              '${endRentalDate.year}/${endRentalDate.month}/${endRentalDate.day}',
              style: TextStyle(fontSize: 20),
            ),
            ElevatedButton(
              child: Text('Select end date'),
              onPressed: () async {
                DateTime? newEndRentalDate =
                await showDatePicker(
                    context: context,
                    initialDate: endRentalDate,
                    firstDate: DateTime(1900),
                    lastDate: DateTime(2100));
                if (newEndRentalDate == null) return;

                setState(
                        () => endRentalDate = newEndRentalDate);
                print(endRentalDate);
                print(sumController);
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
              onPressed: () => payWithCard(),
            ),
          ],
        ),
      ),
    );
  }
}
