<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Coupons;

class CouponBasicFilter  implements ICouponBasicFilter
{
    public $ID;
    public $Discounts;//DiscountBasic
    public $EndDate;
    public $StartDate;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;

}




