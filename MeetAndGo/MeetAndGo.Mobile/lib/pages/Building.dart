import 'package:flutter/material.dart';
import 'package:meet_go_mobile/models/mdlBuilding.dart';
import 'package:meet_go_mobile/services/APIService.dart';
import 'package:meet_go_mobile/pages/BuildingDetails.dart';
import 'dart:typed_data';

class Building extends StatefulWidget {
  @override
  State<Building> createState() => _BuildingState();
}

class _BuildingState extends State<Building> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Building')),
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
