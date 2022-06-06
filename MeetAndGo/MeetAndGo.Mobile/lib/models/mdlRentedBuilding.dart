import 'dart:convert';

class mdlRentedBuilding {
  final int rentedBuildingId;
  final int buildingId;
  final int userId;
  final String beginRentalDate;
  final String endRentalDate;
  final bool rented;
  final String building;
  final String firstName;
  final String lastName;
  final int days;
  final double price;
  final int buildingPrice;
  final String address;
  final List<int> picture;

  mdlRentedBuilding({
    required this.rentedBuildingId,
    required this.buildingId,
    required this.userId,
    required this.beginRentalDate,
    required this.endRentalDate,
    required this.rented,
    required this.building,
    required this.firstName,
    required this.lastName,
    required this.days,
    required this.buildingPrice,
    required this.price,
    required this.address,
    required this.picture,
  });

  factory mdlRentedBuilding.fromJson(Map<String, dynamic> json) {
    String stringByte = json["picture"] as String;
    List<int> bytes = base64.decode(stringByte);
    return mdlRentedBuilding(
      rentedBuildingId: int.parse(json["rentedBuildingId"].toString()),
      buildingId: int.parse(json["buildingId"].toString()),
      userId: int.parse(json["userId"].toString()),
      beginRentalDate: DateTime.parse(json["beginRentalDate"]).toString(),
      endRentalDate: DateTime.parse(json["endRentalDate"]).toString(),
      rented: json["rented"],
      building: json["building"],
      firstName: json["firstname"],
      lastName: json["lastName"],
      days: json["days"],
      buildingPrice: json["buildingPrice"],
      price: json["price"],
      address: json["adress"],
      picture: bytes,
    );
  }
}
