<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Stores;

class Store  implements IStore
{

    public $Fax;
    public $Phone;
    public $Email;
    public $Warehouses;//WarehouseList
    public $Address;//AddressBasic
    public $Title;
    public $Name;
    public $Description;
    public $State;
    public $OrderNo;
    public $ID;
}