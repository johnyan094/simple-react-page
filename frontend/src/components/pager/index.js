import { Product } from "../product/index";
import { ProductDetails } from "../productDetails/index";

export const Pager = ({
  pageNumber,
  productId,
  productHandler,
  backButtonHandler,
}) => {
  const GetPage = () => {
    let pager;
    switch (pageNumber) {
      case 1:
        pager = <Product productHandler={productHandler} />;
        break;
      default:
        pager = (
          <ProductDetails
            productId={productId}
            backButtonHandler={backButtonHandler}
          />
        );
    }

    return pager;
  };

  return GetPage();
};
