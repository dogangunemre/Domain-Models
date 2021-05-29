<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;



use Ohtap\ECommerce\DomainModels\Objects\Attributes\IAttribute;
use Ohtap\ECommerce\DomainModels\Objects\Attributes\IAttributeData;
use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;

class ProductAttributeBasic implements IProductAttributeData
{

    public string $Description;
    public IAttributeData $Attribute;
    public string $Value;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public string $ID;

}