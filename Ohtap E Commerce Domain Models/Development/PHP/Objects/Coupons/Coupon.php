<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Coupons;


class Coupon  implements ICoupon

{   public $ID;
    public $Photo;//FileBasic
    public $Customers;//CustomerDataList
    public $Discounts;//DiscountBasic
    public $EndDate;
    public $StartDate;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;

}

