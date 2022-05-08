class mdlCity {
  final int cityId;
  final String name;

  mdlCity({
    required this.cityId,
    required this.name,
  });

  factory mdlCity.fromJson(Map<String, dynamic> json) {
    return mdlCity(
      cityId: json["cityId"],
      name: json["name"],
    );
  }
}
