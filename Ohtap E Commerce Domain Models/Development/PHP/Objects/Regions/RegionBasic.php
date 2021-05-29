<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Regions;



class RegionBasic implements IRegionData
{
    public IRegion $Parent;
    public string $Description;
    public int $State;
    public int $OrderNo;
    public string $ID;
    public string $Name;

}