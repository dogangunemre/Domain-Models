<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Payments;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IPaymentData extends IPaymentAmount,IPaymentCurrency,IPaymentType,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
