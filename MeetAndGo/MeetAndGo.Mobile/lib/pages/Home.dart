import 'dart:typed_data';

import 'package:flutter/material.dart';
import 'package:meet_go_mobile/services/APIService.dart';

import '../models/mdlBuilding.dart';
import 'BuildingDetails.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Side menu'),
      ),
      drawer: Drawer(
        child: ListView(
          padding: EdgeInsets.zero,
          children: [
            DrawerHeader(
              child: Text(''
                  // 'Side menu',
                  // style: TextStyle(color: Colors.black45, fontSize: 25),
                  ),
              decoration: BoxDecoration(
                  image: DecorationImage(
                      fit: BoxFit.fitWidth,
                      image: AssetImage('assets/office2.jpg'))),
            ),
            ListTile(
                leading: Icon(Icons.location_city),
                title: Text('Building'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/building');
                }),
            ListTile(
                leading: Icon(Icons.attach_money),
                title: Text('Office'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/office');
                }),
            ListTile(
                leading: Icon(Icons.assignment_turned_in_sharp),
                title: Text('Rented Office'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/rentedoffice');
                }),
            ListTile(
                leading: Icon(Icons.assignment_turned_in_sharp),
                title: Text('Rented Building'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/rentedbuilding');
                }),
            ListTile(
                leading: Icon(Icons.exit_to_app),
                title: Text('Logout'),
                onTap: () => {
                      Navigator.of(context).popAndPushNamed('/login'),
                      APIService.username = "",
                      APIService.password = "",
                    }),
          ],
        ),
      ),
      body: bodyWidget(),
    );
  }
  Widget bodyWidget() {
    return FutureBuilder<List<mdlBuilding>>(
      future: GetBuildings(),
      builder: (BuildContext context, AsyncSnapshot<List<mdlBuilding>> snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return Center(child: CircularProgressIndicator());
        } else if (snapshot.hasError) {
          return Center(
            child: Text('${snapshot.error}'),
          );
        } else {
          return ListView(
              children: snapshot.data!.map((e) => BuildingWidget(e)).toList());
        }
      },
    );
  }

  Widget BuildingWidget(building) {
    return Card(
      clipBehavior: Clip.antiAlias,
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => BuildingDetails(product: building)));
        },
        child: Column(
          children: [
            Padding(
                padding: const EdgeInsets.all(13.5),
                child: Image.memory(
                  Uint8List.fromList(building.picture),
                  fit: BoxFit.fill,
                  height: 200,
                  width: 250,
                )),
            Padding(
              padding: const EdgeInsets.all(13.5),
              child: Text(
                building.name,
                style: TextStyle(color: Colors.black.withOpacity(0.7),fontSize: 18),
              ),
            ),
          ],
        ),
      ),
    );
  }

  Future<List<mdlBuilding>> GetBuildings() async {
    var buildings = await APIService.Get('Building', null);
    return buildings!.map((i) => mdlBuilding.fromJson(i)).toList();
  }
}
