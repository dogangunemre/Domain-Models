<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Regions;

class Region  implements IRegion
{


    public IRegionDetailData $Details;
    public ITaxData $Tax;
    public IRegionList $Childs;
    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $ID;
    public string $Name;
    public IRegion $Parent;
}