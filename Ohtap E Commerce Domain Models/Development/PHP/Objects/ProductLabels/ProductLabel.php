<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;

use Ohtap\ECommerce\DomainModels\Objects\Attributes\IAttributeData;
use Ohtap\ECommerce\DomainModels\Objects\Labels\ILabelData;


class ProductLabel  implements IProductLabel
{

    public string $Description;
    public ILabelData $Label;
    public string $Value;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public string $ID;

}