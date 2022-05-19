import 'package:flutter/material.dart';
import 'package:meet_go_mobile/services/APIService.dart';

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
                title: Text('Office rent'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/officerent');
                }),
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
    );
  }
}
