import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlRentedOffice.dart';
import 'package:meet_go_mobile/models/mdlUserAccount.dart';
import 'dart:typed_data';
import '../services/APIService.dart';
import 'RentedOfficeDetails.dart';

class RentedOffice extends StatefulWidget {
  @override
  State<RentedOffice> createState() => _RentedOfficeState();

}

var loggedUser;

void fetchUser() async {
  var user = await APIService.GetByUsername('User', APIService.username );
  loggedUser = user!.map((e) => mdlUserAccount.fromJson(e)).first;
}

class _RentedOfficeState extends State<RentedOffice> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Rented offices')),
      body: bodyWidget(),
    );
  }

 Widget bodyWidget() {
    return FutureBuilder<List<mdlRentedOffice>>(
      future: GetRentedOffices(),
      builder: (BuildContext context, AsyncSnapshot<List<mdlRentedOffice>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return Center(child: CircularProgressIndicator());
        } else if (snapshot.hasError) {
          return Center(
            child: Text('No reservations currently made'),
          );
        } else {
          return ListView(
              children: snapshot.data!.map((e) => RentedOfficeWidget(e)).toList());
        }
      },
    );
  }

  Widget RentedOfficeWidget(rentedoffices) {
    return Card(
      clipBehavior: Clip.antiAlias,
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => RentedOfficeDetails(product: rentedoffices)));
        },
        child: Column(
          children: [
            Padding(
                padding: const EdgeInsets.all(13.5),
                child: Image.memory(
                  Uint8List.fromList(rentedoffices.picture),
                  fit: BoxFit.fill,
                  height: 200,
                  width: 250,
                )),
            Padding(
              padding: const EdgeInsets.all(13.5),
              child: Text(
                rentedoffices.office,
                style: TextStyle(color: Colors.black.withOpacity(0.7),fontSize: 18),
              ),
            ),
          ],
        ),
      ),
    );
  }

  Future<List<mdlRentedOffice>> GetRentedOffices() async {
    fetchUser();
    var rentedoffices = await APIService.GetListById('RentedOffice/user',loggedUser.userId);
    return rentedoffices!.map((i) => mdlRentedOffice.fromJson(i)).toList();
  }
}