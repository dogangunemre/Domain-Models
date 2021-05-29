<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Cargos;
use Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ICargoData extends ICargoEmail,ICargoFax,ICargoPhone,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{


}