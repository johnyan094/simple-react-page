import { useEffect, useState } from "react";
import * as Productservice from "../../services/productService";
import style from "./product.module.scss";

export const Product = ({ productHandler }) => {
  const [products, setProducts] = useState(null);

  useEffect(() => {
    async function GetProducts() {
      var result = await Productservice.GetProducts();
      setProducts(result);
    }
    GetProducts();
  }, []);

  const GetProductTable = () => {
    var lines = products.map((product) => {
      return (
        <tr key={product.sku}>
          <td>{product.id}</td>
          <td>{product.sku}</td>
          <td>
            <a
              className={style.link}
              onClick={() => productHandler(product.id)}
            >
              {product.name}
            </a>
          </td>
        </tr>
      );
    });

    var table = (
      <table className={style.tableContainer}>
        <thead>
          <tr>
            <th>Id</th>
            <th>SKU</th>
            <th>Name</th>
          </tr>
        </thead>
        <tbody>{lines}</tbody>
      </table>
    );
    return table;
  };

  return (
    <>
      <h3>Product List Page</h3>

      {products && GetProductTable()}
    </>
  );
};
