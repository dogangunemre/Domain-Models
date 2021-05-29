<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Regions;

class RegionBasicFilter  implements IRegionBasicFilter
{
    public IRegion $Parent;
    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $ID;
    public string $Name;

}

