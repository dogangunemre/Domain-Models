<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;



use Ohtap\ECommerce\DomainModels\Objects\Attributes\IAttribute;
use Ohtap\ECommerce\DomainModels\Objects\Attributes\IAttributeData;
use Ohtap\ECommerce\DomainModels\Objects\Discounts\IDiscountData;
use Ohtap\ECommerce\DomainModels\Objects\Labels\ILabelData;

class ProductLabelBasic implements IProductLabelData
{

    public string $Description;
    public ILabelData $Label;
    public string $Value;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public string $ID;

}