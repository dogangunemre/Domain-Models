<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Products;

use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;

class ProductDetailBasicFilter  implements IProductBasicFilter
{
    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public int $ID;


}

