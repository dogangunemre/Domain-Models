<?php
namespace Ohtap\ECommerce\DomainModels\Objects\CouponDetail;

class CouponDetailBasicFilter  implements ICouponDetailBasicFilter
{
    public string $ID;
    public string $Name;
    public int $State;
    public int $OrderNo;
    public string $Description;
}

