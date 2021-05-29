<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Customers;

class CustomerBasicFilter implements  ICustomerBasicFilter
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