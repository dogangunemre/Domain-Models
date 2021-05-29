<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Invoices;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IInvoiceData extends IInvoiceDate,IInvoiceTotalPrice,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
