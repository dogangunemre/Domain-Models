<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Invoices;

class Invoice  implements IInvoice
{

    public $Photo;//FileBasic
    public $Customer;//CustomerBasic
    public $Date;
    public $TotalPrice;
    public $ID;
    public $Title;
    public $State;
    public $OrderNo;
    public $Description;
}