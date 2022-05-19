import 'dart:convert';

class mdlBuilding {
  final int buildingId;
  final String name;
  final String address;
  final String description;
  final String area;
  final int price;
  final List<int> picture;
  final bool rented;
  final int numberOfFloors;
  final int cityId;
  final int typeOfBuildingId;
  final int numberOfOffices;
  final bool isDeleted;
  final bool security;
  final bool cameras;
  final bool parking;

  mdlBuilding({
    required this.buildingId,
    required this.name,
    required this.address,
    required this.description,
    required this.area,
    required this.price,
    required this.picture,
    required this.rented,
    required this.numberOfFloors,
    required this.cityId,
    required this.typeOfBuildingId,
    required this.numberOfOffices,
    required this.isDeleted,
    required this.security,
    required this.cameras,
    required this.parking,
  });

  factory mdlBuilding.fromJson(Map<String, dynamic> json) {
    String stringByte = json["picture"] as String;
    List<int> bytes = base64.decode(stringByte);
    return mdlBuilding(
        buildingId: int.parse(json["buildingId"].toString()),
        name: json["name"],
        address: json["adress"],
        description: json["description"],
        area: json["area"],
        picture: bytes,
        price: json["price"],
        rented: json["rented"],
        numberOfFloors: json["numberOfFloors"],
        cityId: json["cityId"],
        typeOfBuildingId: json["typeOfBuildingId"],
        numberOfOffices: json["numberOfOffices"],
        isDeleted: json["isDeleted"],
        security: json["security"],
        cameras: json["cameras"],
        parking: json["parking"]);
  }
}
