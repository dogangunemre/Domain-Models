<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Products;



class ProductBasicFilter  implements IProductBasicFilter
{
    public string $Description;
    public string $Barcode;
    public string $SKU;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public int $ID;


}

