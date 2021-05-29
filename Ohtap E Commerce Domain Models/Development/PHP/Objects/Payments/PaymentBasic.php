<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Payments;



class PaymentBasic implements IPaymentData
{
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