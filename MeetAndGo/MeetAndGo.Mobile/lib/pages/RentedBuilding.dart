import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlRentedBuilding.dart';
import 'package:meet_go_mobile/models/mdlUserAccount.dart';
import 'dart:typed_data';
import '../services/APIService.dart';
import 'RentedBuildingDetails.dart';
import 'RentedOfficeDetails.dart';

class RentedBuilding extends StatefulWidget {
  @override
  State<RentedBuilding> createState() => _RentedBuildingState();

}

var loggedUser;

void fetchUser() async {
  var user = await APIService.GetByUsername('User', APIService.username );
  loggedUser = user!.map((e) => mdlUserAccount.fromJson(e)).first;
}

class _RentedBuildingState extends State<RentedBuilding> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Rented buildings')),
      body: bodyWidget(),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder<List<mdlRentedBuilding>>(
      future: GetRentedBuildings(),
      builder: (BuildContext context, AsyncSnapshot<List<mdlRentedBuilding>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return Center(child: CircularProgressIndicator());
        } else if (snapshot.hasError) {
          return Center(
            child: Text('No reservations currently made'),
          );
        } else {
          return ListView(
              children: snapshot.data!.map((e) => RentedBuildingWidget(e)).toList());
        }
      },
    );
  }

  Widget RentedBuildingWidget(rentedbuilding) {
    return Card(
      clipBehavior: Clip.antiAlias,
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => RentedBuildingDetails(product: rentedbuilding)));
        },
        child: Column(
          children: [
            Padding(
                padding: const EdgeInsets.all(13.5),
                child: Image.memory(
                  Uint8List.fromList(rentedbuilding.picture),
                  fit: BoxFit.fill,
                  height: 200,
                  width: 250,
                )),
            Padding(
              padding: const EdgeInsets.all(13.5),
              child: Text(
                rentedbuilding.building,
                style: TextStyle(color: Colors.black.withOpacity(0.7),fontSize: 18),
              ),
            ),
          ],
        ),
      ),
    );
  }

  Future<List<mdlRentedBuilding>> GetRentedBuildings() async {
    fetchUser();
    var rentedbuildings = await APIService.GetListById('RentedBuilding/user',loggedUser.userId);
    return rentedbuildings!.map((i) => mdlRentedBuilding.fromJson(i)).toList();
  }
}