<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Invoices;



class InvoiceBasic implements IInvoiceData
{
    public $Date;
    public $TotalPrice;
    public $ID;
    public $Title;
    public $State;
    public $OrderNo;
    public $Description;

}