import 'dart:typed_data';
import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlBuilding.dart';
import 'package:meet_go_mobile/models/mdlCity.dart';
import 'package:meet_go_mobile/services/APIService.dart';
import 'package:meet_go_mobile/models/mdlUserAccount.dart';
import 'dart:async';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

import '../models/mdlOffice.dart';
import '../models/mdlTypeOfOffice.dart';
import 'RentOffice.dart';

var beginRentalDate = DateTime(2022, 6, 5);
var endRentalDate = DateTime(2022, 8, 8);
var dateDiff;

class OfficeDetails extends StatefulWidget {
  final mdlOffice product;

  const OfficeDetails({Key? key, required this.product}) : super(key: key);

  @override
  State<OfficeDetails> createState() => _OfficeDetailsState();
}

class _OfficeDetailsState extends State<OfficeDetails> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('Office details'),
        ),
        body: Card(
          clipBehavior: Clip.antiAlias,
          child: Column(children: [
            Padding(
              padding: const EdgeInsets.all(7.0),
              child: Image.memory(Uint8List.fromList(widget.product.picture),
                  fit: BoxFit.fill, height: 200, width: 250),
            ),
            ListTile(
              title: Text(
                widget.product.name,
                style: TextStyle(color: Colors.black, fontSize: 23),
              ),
              subtitle: Text(
                widget.product.description,
                style: TextStyle(
                    color: Colors.black.withOpacity(0.7), fontSize: 17),
              ),
            ),
            Text(
              widget.product.price.toString() + '' + '€',
              style: TextStyle(
                  color: Colors.lightBlue.withOpacity(1.0),
                  fontSize: 22,
                  fontWeight: FontWeight.bold),
            ),
            Padding(
              padding: const EdgeInsets.fromLTRB(0, 16, 0, 0),
              child: MyWidget(widget, context),
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
                    Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) =>
                                RentOffice(product: widget.product)));
                  },
                ),
              ],
            ),
          ]),
        ));
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
                    widget.product.area,
                    style: TextStyle(
                        color: Colors.lightGreen,
                        fontWeight: FontWeight.bold,
                        fontSize: 17),
                  ),
                  padding: EdgeInsets.fromLTRB(55, 10, 10, 10),
                ),
                Padding(
                  child: Text(
                    widget.product.address,
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
                'Type of office',
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
                FutureBuilder<mdlTypeOfOffice>(
                  future: fetchTypeOfOffice(),
                  builder: (BuildContext context,
                      AsyncSnapshot<mdlTypeOfOffice> snapshot) {
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
                        padding: EdgeInsets.fromLTRB(55, 10, 10, 10),
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
                value: widget.product.parking,
                contentPadding: EdgeInsets.fromLTRB(80, 0, 0, 0),
                onChanged: null,
                controlAffinity:
                ListTileControlAffinity.leading, //  <-- leading Checkbox
              ),
              CheckboxListTile(
                value: widget.product.cameras,
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

  Future<mdlCity> fetchCity() async {
    var city = await APIService.GetById('City', widget.product.cityId);
    mdlCity model = mdlCity.fromJson(city);
    return model;
  }

  Future<mdlTypeOfOffice> fetchTypeOfOffice() async {
    var typeOfOffice =
    await APIService.GetById('TypeOfOffice', widget.product.typeOfOfficeId);
    mdlTypeOfOffice model = mdlTypeOfOffice.fromJson(typeOfOffice);
    return model;
  }
}
