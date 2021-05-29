<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Products;



use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;

class ProductDetailBasic implements IProductData
{

    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public int $ID;

}