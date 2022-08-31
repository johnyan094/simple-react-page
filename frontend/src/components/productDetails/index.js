import { useEffect, useState } from "react";
import * as Productservice from "../../services/productService";

export const ProductDetails = ({ productId, backButtonHandler }) => {
  const [productDetails, setProductDetails] = useState(null);

  useEffect(() => {
    async function GetProductDetail() {
      var result = await Productservice.GetProductDetail(productId);
      setProductDetails(result);
    }
    GetProductDetail();
  }, [productId]);

  return (
    <>
      <h3>Product Details page</h3>

      {productDetails && (
        <dl>
          <dt>Description</dt>
          <dd>{productDetails.description}</dd>
          <dt>Quantity</dt>
          <dd>{productDetails.quantity}</dd>
          <dt>Price</dt>
          <dd>{productDetails.price.toFixed(2)}</dd>
        </dl>
      )}
      <button onClick={backButtonHandler}>Back to Products</button>
    </>
  );
};
