import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlCity.dart';
import 'package:meet_go_mobile/models/mdlTypeOfOffice.dart';
import 'package:meet_go_mobile/services/APIService.dart';
import 'dart:typed_data';

import '../models/mdlRentedOffice.dart';

class RentedOfficeDetails extends StatelessWidget {
  final mdlRentedOffice product;

  const RentedOfficeDetails({Key? key, required this.product})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text('Rented office details'),
        ),
        body: Main(dynamic, dynamic));
  }

  Widget Main(widget, content) {
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
            product.office,
            style: TextStyle(color: Colors.black, fontSize: 23),
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
          child: MyWidget(dynamic, dynamic),
        ),
        ButtonBar(
          alignment: MainAxisAlignment.center,
          buttonMinWidth: 300,
          children: [],
        ),
      ]),
    );
  }

  Widget MyWidget(widget, content) {
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
                'Address',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),
                textAlign: TextAlign.center,
              ),
              Text(
                'Days rented',
                style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),
                textAlign: TextAlign.center,
              ),
            ]),
            TableRow(
              children: [
                Padding(
                  child: Text(
                    product.address,
                    style: TextStyle(
                        color: Colors.lightGreen,
                        fontWeight: FontWeight.bold,
                        fontSize: 17),
                  ),
                  padding: EdgeInsets.fromLTRB(65, 10, 10, 10),
                ),
                Padding(
                  child: Text(
                    product.days.toString(),
                    style: TextStyle(
                        color: Colors.lightGreen,
                        fontWeight: FontWeight.bold,
                        fontSize: 17),
                  ),
                  padding: EdgeInsets.fromLTRB(85, 10, 10, 10),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
