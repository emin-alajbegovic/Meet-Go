class mdlTypeOfBuilding {
  final int typeOfBuildingId;
  final String name;

  mdlTypeOfBuilding({
    required this.typeOfBuildingId,
    required this.name,
  });

  factory mdlTypeOfBuilding.fromJson(Map<String, dynamic> json) {
    return mdlTypeOfBuilding(
      typeOfBuildingId: json["typeOfBuildingId"],
      name: json["name"],
    );
  }
}
