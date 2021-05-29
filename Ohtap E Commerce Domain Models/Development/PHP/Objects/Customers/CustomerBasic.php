<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Customers;

class CustomerBasic implements ICustomerData
{
    public $ID;
    public $CitizenNumber;
    public $Gender;
    public $Nationality;
    public $DateOfBirth;
    public $Email;
    public $Phone;
    public $Title;
    public $Photo;//FileBasic
    public $Details;
    public $State;
    public $OrderNo;
    public $Description;

}