import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlOffice.dart';
import 'package:meet_go_mobile/services/APIService.dart';
import 'package:meet_go_mobile/pages/OfficeDetails.dart';
import 'dart:typed_data';

class Office extends StatefulWidget {
  @override
  State<Office> createState() => _OfficeState();
}

class _OfficeState extends State<Office> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Offices')),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder<List<mdlOffice>>(
      future: GetOffices(),
      builder: (BuildContext context, AsyncSnapshot<List<mdlOffice>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return Center(child: CircularProgressIndicator());
        } else if (snapshot.hasError) {
          return Center(
            child: Text('${snapshot.error}'),
          );
        } else {
          return ListView(
              children: snapshot.data!.map((e) => OfficeWidget(e)).toList());
        }
      },
    );
  }

  Widget OfficeWidget(office) {
    return Card(
      clipBehavior: Clip.antiAlias,
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => OfficeDetails(product: office)));
        },
        child: Column(
          children: [
            Padding(
                padding: const EdgeInsets.all(13.5),
                child: Image.memory(
                  Uint8List.fromList(office.picture),
                  fit: BoxFit.fill,
                  height: 200,
                  width: 250,
                )),
            Padding(
              padding: const EdgeInsets.all(13.5),
              child: Text(
                office.name,
                style: TextStyle(color: Colors.black.withOpacity(0.7),fontSize: 18),
              ),
            ),
          ],
        ),
      ),
    );
  }

  Future<List<mdlOffice>> GetOffices() async {
    var offices = await APIService.Get('Office', null);
    return offices!.map((i) => mdlOffice.fromJson(i)).toList();
  }
}
