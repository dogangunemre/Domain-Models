<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;

use Ohtap\ECommerce\DomainModels\Objects\Attributes\IAttributeData;


class ProductAttributeBasicFilter  implements IProductAttributeBasicFilter
{
    public string $Description;
    public IAttributeData $Attribute;
    public string $Value;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public string $ID;


}

