<?php
namespace Ohtap\ECommerce\DomainModels\Objects\OrderItems;



class OrderItemBasic implements IOrderItemData
{

    public $Amount;
    public $ItemType;//OrderTypes
    public $Product;//Product
    public $Package;//Package
    public $Description;
    public $State;
    public $OrderNo;
    public $ID;

}