<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Customers;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;




interface ICustomerData extends  ICustomerDateOfBirth,ICustomerNationality,ICustomerPhoto,ICustomerCitizenNumber,ICustomerEmail,ICustomerGender,ICustomerPhone,CoreObjects\IObjectID, CoreObjects\IObjectCode, CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}