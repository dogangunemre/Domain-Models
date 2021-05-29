<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Customers;

class Customer implements ICustomer
{

    public $ID;
    public $Coupons;//CouponList
    public $Addresses;//AddressList
    public $Curreincies;//CurreincyList
    public $Discounts;//DiscountList
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