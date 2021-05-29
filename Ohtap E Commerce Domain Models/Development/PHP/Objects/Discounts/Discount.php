<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Discounts;

class Discount  implements IDiscount
{

    public $ID;
    public $Title;
    public $Name;
    public $State;
    public $OrderNo;
    public $Description;
}