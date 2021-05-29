<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Shippings;



class ShippingBasic implements IShippingData
{
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