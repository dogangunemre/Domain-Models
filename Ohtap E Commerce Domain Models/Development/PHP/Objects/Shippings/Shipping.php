<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Shippings;

class Shipping  implements IShipping
{

    public $Cargo;//CargoBasic
    public $Payment;//PaymentBasic
    public $Title;
    public $Name;
    public $Email;
    public $Fax;
    public $Address;//AddressBasic
    public $Phone;
    public $Description;
    public $State;
    public $OrderNo;
    public $ID;
}