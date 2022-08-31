const GetUrl = (method) => {
  return "https://localhost:44353/" + method;
};

export const GetProducts = async () => {
  var url = GetUrl("product");
  var result = await fetch(url, {
    method: "GET",
  });

  return result.json();
};

export const GetProductDetail = async (id) => {
  var result = await fetch(GetUrl(`product/${id}`), {
    method: "GET",
  });

  return result.json();
};
