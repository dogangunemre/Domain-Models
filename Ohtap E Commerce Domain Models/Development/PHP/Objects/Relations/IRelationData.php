<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Relations;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IRelationData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
