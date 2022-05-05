import 'dart:convert';

class mdlOffice {
  final int officeId;
  final String name;
  final String address;
  final String description;
  final String area;
  final int price;
  final List<int> picture;
  final bool rented;
  final int numberOfFloors;
  final int cityId;
  final int typeOfOfficeId;
  final bool isDeleted;
  final bool parking;
  final bool cameras;

  mdlOffice({
    required this.officeId,
    required this.name,
    required this.address,
    required this.description,
    required this.area,
    required this.price,
    required this.picture,
    required this.rented,
    required this.numberOfFloors,
    required this.cityId,
    required this.typeOfOfficeId,
    required this.isDeleted,
    required this.parking,
    required this.cameras,
  });

  factory mdlOffice.fromJson(Map<String, dynamic> json) {
    String stringByte = json["picture"] as String;
    List<int> bytes = base64.decode(stringByte);
    return mdlOffice(
        officeId: int.parse(json["officeId"].toString()),
        name: json["name"],
        address: json["adress"],
        description: json["description"],
        area: json["area"],
        picture: bytes,
        price: int.parse(json["price"].toString()),
        rented: json["rented"],
        numberOfFloors: json["numberOfFloors"],
        cityId: json["cityId"],
        typeOfOfficeId: json["typeOfOfficeId"],
        isDeleted: json["isDeleted"],
        parking: json["parking"],
        cameras: json["cameras"]);
  }
}
