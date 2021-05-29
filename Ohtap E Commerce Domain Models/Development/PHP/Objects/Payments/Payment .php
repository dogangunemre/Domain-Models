<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Payments;

class Payment  implements IPayment
{

    public $Customers;//Customer
    public $Bank;//Bank
    public $Currency;//Currency
    public $Types;//PaymentTypes
    public $Amount;
    public $Title;
    public $Name;
    public $Value;
    public $Description;
    public $State;
    public $OrderNo;
    public $ID;
}