<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Promotions;

use Ohtap\ECommerce\DomainModels\Objects\Attributes\IAttributeData;
use Ohtap\ECommerce\DomainModels\Objects\Labels\ILabelData;
use Ohtap\ECommerce\DomainModels\Objects\Options\IOptionData;


class ProductOption  implements IProductOption
{

    public string $Description;
    public IOptionData $Option;
    public string $Value;
    public int $State;
    public int $OrderNo;
    public string $Name;
    public string $ID;

}