import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlOffice.dart';
import 'dart:typed_data';

class OfficeDetails extends StatelessWidget {
  final mdlOffice product;

  const OfficeDetails({Key? key, required this.product}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Office details'),
      ),
      body: Card(
        clipBehavior: Clip.antiAlias,
        child: Column(
          children: [
            Padding(
              padding: const EdgeInsets.all(16.0),
              child: Image.memory(Uint8List.fromList(product.picture),
                  fit: BoxFit.fill, height: 200, width: 250),
            ),
            ListTile(
              title: Text(
                product.name,
                style: TextStyle(color: Colors.black,fontSize: 20),
              ),
              subtitle: Text(
                product.address,
                style: TextStyle(color: Colors.black.withOpacity(0.7)),
              ),
            ),
            Padding(
              padding: const EdgeInsets.all(16.0),
              child: Text(
                product.description,
                style: TextStyle(color: Colors.black.withOpacity(0.6)),
              ),
            ),
            ButtonBar(
              alignment: MainAxisAlignment.start,
              children: [
                FlatButton(
                  textColor: const Color(0xFF6200EE),
                  onPressed: () {
                    // Perform some action
                  },
                  child: const Text('Rent'),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
