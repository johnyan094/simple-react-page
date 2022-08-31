import { useState } from "react";
import { Pager } from "./components/pager";
import style from "./App.module.scss";

export const App = () => {
  const [pageNumber, setPageNumber] = useState(1);
  const [productId, setProductId] = useState(null);

  const productHandler = (productId) => {
    setProductId(productId);
    setPageNumber(2);
  };

  const backButtonHandler = () => {
    setProductId(null);
    setPageNumber(1);
  };

  return (
    <div className={style.App}>
      <div>
        <Pager
          pageNumber={pageNumber}
          productId={productId}
          productHandler={productHandler}
          backButtonHandler={backButtonHandler}
        />
      </div>
    </div>
  );
};
