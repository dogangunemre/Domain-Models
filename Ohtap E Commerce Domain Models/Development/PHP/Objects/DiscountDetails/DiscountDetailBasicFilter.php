<?php
namespace Ohtap\ECommerce\DomainModels\Objects\DiscountDetail;

class DiscountDetailBasicFilter  implements IDiscountDetailBasicFilter
{
    public string $ID;
    public string $Name;
    public int $State;
    public int $OrderNo;
    public string $Description;
}

