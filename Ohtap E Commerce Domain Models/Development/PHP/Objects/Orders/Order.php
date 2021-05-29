<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Orders;

class Order  implements IOrder
{


    public $Payments;//PaymentList tipi
    public $Discounts;//DiscountList tipi
    public $Packages;//PackageList tipi
    public $Items;//OrderItemList tipi
    public $Campaigns;//CampaignList tipi
    public $Coupons;//CouponList tipi
    public $Invoice;//InvoiceList tipi
    public $Shippings;//ShippingList tipi
    public $InvoiceAddress;//InvoiceAddressList tipi
    public $DeliveryAddress;//DeliveryAddressList tipi
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