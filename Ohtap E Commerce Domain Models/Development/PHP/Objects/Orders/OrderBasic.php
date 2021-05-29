<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Orders;



class OrderBasic implements IOrderData
{
    public $TotalPrice;
    public $Note;
    public $Store;//Store classı tipinde olacak
    public $Description;
    public $State;
    public $OrderNo;
    public $Title;
    public $Name;
    public $ID;

}