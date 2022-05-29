import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlBuilding.dart';
import 'package:meet_go_mobile/models/mdlCity.dart';
import 'package:meet_go_mobile/models/mdlTypeOfBuilding.dart';
import 'package:meet_go_mobile/services/APIService.dart';
import 'package:meet_go_mobile/models/mdlUserAccount.dart';
import 'dart:async';
import 'dart:typed_data';

final beginRentalDate = DateTime.utc(1989, DateTime.november, 9);
final endRentalDate = DateTime.utc(1944, DateTime.june, 6);

final difference = endRentalDate.difference(beginRentalDate);

class BuildingDetails extends StatelessWidget {
  final mdlBuilding product;

  var loggedUser;

  Future<mdlCity> fetchCity() async {
    print(difference.inDays);
    var city = await APIService.GetById('City', product.cityId);
    mdlCity model = mdlCity.fromJson(city);
    return model;
  }

  Future<mdlTypeOfBuilding> fetchTypeOfBuilding() async {
    var typeOfBuilding =
        await APIService.GetById('TypeOfBuilding', product.typeOfBuildingId);
    mdlTypeOfBuilding model = mdlTypeOfBuilding.fromJson(typeOfBuilding);
    return model;
  }

  void payWithCard() async {
    var user = await APIService.GetByUsername('User', APIService.username );
    loggedUser = user!.map((e) => mdlUserAccount.fromJson(e)).first;

    Map<String, dynamic> queryParams = {
      'buildingId': product.buildingId,
      'userId': loggedUser.userId,
      'beginRentalDate': '2022-05-25T17:03:01.645Z',
      'endRentalDate': '2023-05-25T17:03:01.645Z',
      'rented': true,
      'days': difference.inDays,
      'price': product.price
    };
    var result = await APIService.Post('RentedBuilding', queryParams);
  }

  BuildingDetails({Key? key, required this.product}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('Building details'),
        ),
        body: Main(dynamic, context));
  }

  Widget Main(widget, BuildContext context) {

    return Card(
      clipBehavior: Clip.antiAlias,
      child: Column(children: [
        Padding(
          padding: const EdgeInsets.all(7.0),
          child: Image.memory(Uint8List.fromList(product.picture),
              fit: BoxFit.fill, height: 200, width: 250),
        ),
        ListTile(
          title: Text(
            product.name,
            style: TextStyle(color: Colors.black, fontSize: 23),
          ),
          subtitle: Text(
            product.description,
            style:
                TextStyle(color: Colors.black.withOpacity(0.7), fontSize: 17),
          ),
        ),
        Text(
          product.price.toString() + '' + '€',
          style: TextStyle(
              color: Colors.lightBlue.withOpacity(1.0),
              fontSize: 22,
              fontWeight: FontWeight.bold),
        ),
        Padding(
          padding: const EdgeInsets.fromLTRB(0, 16, 0, 0),
          child: MyWidget(dynamic, context),
        ),
        ButtonBar(
          alignment: MainAxisAlignment.center,
          buttonMinWidth: 300,
          children: [
            RaisedButton(
              child: Text("Rent"),
              textColor: Colors.white,
              color: Colors.green,
              onPressed: () {
                showDialog(
                    context: context,
                    builder: (BuildContext context) => AlertDialog(
                          title: Text('Rent Building'),
                          content: SingleChildScrollView(
                            child: ListBody(
                              children: const <Widget>[
                              ],
                            ),
                          ),
                          actions: [
                            Text(
                              'Price per day: ' + product.price.toString() + '' + '€',
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
                              },
                            ),
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
                              },
                            ),
                            Text(
                              'Total price: ' + product.price.toString() + '€',
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
                        ));
              },
            ),
          ],
        ),
      ]),
    );
  }

  Widget MyWidget(widget, BuildContext context) {
    return Container(
      padding: EdgeInsets.only(bottom: 10),
      child: Center(
        child: Table(
          border: TableBorder(
              verticalInside: BorderSide(
                  width: 1.0, color: Colors.black, style: BorderStyle.solid)),
          children: [
            TableRow(children: [
              Text(
                'Area',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),
                textAlign: TextAlign.center,
              ),
              Text(
                'Address',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),
                textAlign: TextAlign.center,
              ),
            ]),
            TableRow(
              children: [
                Padding(
                  child: Text(
                    product.area,
                    style: TextStyle(
                        color: Colors.lightGreen,
                        fontWeight: FontWeight.bold,
                        fontSize: 17),
                  ),
                  padding: EdgeInsets.fromLTRB(55, 10, 10, 10),
                ),
                Padding(
                  child: Text(
                    product.address,
                    style: TextStyle(
                        color: Colors.lightGreen,
                        fontWeight: FontWeight.bold,
                        fontSize: 17),
                  ),
                  padding: EdgeInsets.fromLTRB(55, 10, 10, 10),
                ),
              ],
            ),
            TableRow(children: [
              Text(
                'Type of building',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),
                textAlign: TextAlign.center,
              ),
              Text(
                'City',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),
                textAlign: TextAlign.center,
              ),
            ]),
            TableRow(
              children: [
                FutureBuilder<mdlTypeOfBuilding>(
                  future: fetchTypeOfBuilding(),
                  builder: (BuildContext context,
                      AsyncSnapshot<mdlTypeOfBuilding> snapshot) {
                    if (snapshot.connectionState == ConnectionState.waiting) {
                      return Center(
                        child: Text("Loading..."),
                      );
                    } else if (snapshot.hasError) {
                      return Center(
                        child: Text('Error...'),
                      );
                    } else {
                      return Padding(
                        child: Text(
                          snapshot.data!.name,
                          style: TextStyle(
                              color: Colors.lightGreen,
                              fontWeight: FontWeight.bold,
                              fontSize: 17),
                        ),
                        padding: EdgeInsets.fromLTRB(65, 10, 10, 10),
                      );
                    }
                  },
                ),
                FutureBuilder<mdlCity>(
                  future: fetchCity(),
                  builder:
                      (BuildContext context, AsyncSnapshot<mdlCity> snapshot) {
                    if (snapshot.connectionState == ConnectionState.waiting) {
                      return Center(
                        child: Text("Loading..."),
                      );
                    } else if (snapshot.hasError) {
                      return Center(
                        child: Text('Error...'),
                      );
                    } else {
                      return Padding(
                        child: Text(
                          snapshot.data!.name,
                          style: TextStyle(
                              color: Colors.lightGreen,
                              fontWeight: FontWeight.bold,
                              fontSize: 17),
                        ),
                        padding: EdgeInsets.fromLTRB(75, 10, 10, 10),
                      );
                    }
                  },
                ),
              ],
            ),
            TableRow(children: [
              Text(
                'Parking',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),
                textAlign: TextAlign.center,
              ),
              Text(
                'Cameras',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),
                textAlign: TextAlign.center,
              ),
            ]),
            TableRow(children: [
              CheckboxListTile(
                value: product.parking,
                contentPadding: EdgeInsets.fromLTRB(80, 0, 0, 0),
                onChanged: null,
                controlAffinity:
                    ListTileControlAffinity.leading, //  <-- leading Checkbox
              ),
              CheckboxListTile(
                value: product.cameras,
                onChanged: null,
                contentPadding: EdgeInsets.fromLTRB(80, 0, 0, 0),
                controlAffinity:
                    ListTileControlAffinity.leading, //  <-- leading Checkbox
              ),
            ]),
          ],
        ),
      ),
    );
  }
}
