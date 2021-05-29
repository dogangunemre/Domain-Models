<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Regions;

use Ohtap\ECommerce\DomainModels\Objects\Languages\ILanguage;

class RegionDetail  implements IRegionDetail
{


    public  ILanguage $Language;
    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $ID;
    public string $Name;

}