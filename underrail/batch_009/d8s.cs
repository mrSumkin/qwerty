using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000FF6 RID: 4086
public static class d8s
{
	// Token: 0x06005417 RID: 21527 RVA: 0x0025374C File Offset: 0x0025194C
	public static bool b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b(d8o.t);
	}

	// Token: 0x06005418 RID: 21528 RVA: 0x00253798 File Offset: 0x00251998
	public static void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			string a_ = "::Это слишком запутанно. От этого у вас болит голова.::";
			c0s aspect = serviceOrThrow.aqu().v().b().GetAspect<c0s>();
			if (aspect != null)
			{
				aspect.a(a_, true, null, null);
			}
		}
	}

	// Token: 0x06005419 RID: 21529 RVA: 0x00253820 File Offset: 0x00251A20
	public static bool a(string A_0)
	{
		d8s.a a = new d8s.a();
		a.a = A_0;
		return Enumerable.Any<string>(Enumerable.ToList<string>(Enumerable.Where<string>(new List<string>
		{
			"cc_researchFacility",
			"cc_rfComputer",
			"cc_whuConsole",
			"cc_zamanConsole1",
			"cc_zamanConsole2",
			"evelynsLaptop",
			"fo_prisonConsole",
			"fo4_arcConsole",
			"fo5_console",
			"hro_dataStorageComputer",
			"hro_entranceComputer",
			"lu-raf_entranceConsole",
			"lux_b1_Console",
			"lux_b2_console",
			"lux_md_computer",
			"lux_md_freezerControl",
			"merchantsPDA",
			"plb_computer",
			"sgs_medicalComputer",
			"sgs_patsLaptop",
			"StationAlpha_shootingRangeConsole",
			"wa_database",
			"ceto_DeckLog",
			"CommunicationConsoles",
			"fort_entrancePanel",
			"fu_securityConsole",
			"le_seegersComputer",
			"mc_secConsole",
			"microchipEncoder",
			"microchipImplanter",
			"navcom",
			"rig_comm",
			"rig_sonarPc",
			"slimyTablet",
			"submarine",
			"techniciansComm",
			"wumb_pc",
			"xpbl_ojyc_consoles",
			"xpbl_ojyc_facilityLogs",
			"wumb_trgomat",
			"cc_sewerPowerGen",
			"ForlornStations_powerGen",
			"hro_powerGen",
			"sgs_stasisConsole",
			"dun_cc_sChannels_mainConsole",
			"dun_cc_sFurnace_mainConsole",
			"dun_ccResOfficeBotConsole",
			"dun_ccResOfficeLaptop",
			"dun_lowLevelBunker3_mainConsole",
			"dun_lowLevelCave4_crane",
			"dc_compilerLog",
			"dc-pp_consoles",
			"dc-pp_powerConsole",
			"dc-tch_eideinsPassage",
			"dc-tch_keypad",
			"dc_inm_bianka",
			"dc_inm_dyson",
			"dc_inm_gunter",
			"dc_inm_hope",
			"dc_inm_mali",
			"dc_inm_manu",
			"dc_inm_parkinson",
			"dc_inm_slavkovic",
			"dc_inm_wasi",
			"dc_mutagenCombinator",
			"dc_mutagenScanner",
			"dc_sequenceDatabase",
			"dc_tchortConsole",
			"dc_tl_mainConsole",
			"dc-le_gasMachine",
			"tch_mu2Console",
			"tch_mu2Pipe",
			"dun_up_it1Console",
			"cc_utility1_boilerConsole",
			"cc_utility2_powerGrid",
			"cc_utility2_laptop",
			"railcar",
			"gunslingersEnergyPistolInactive",
			"exo_trainingGroundsConsole",
			"exo_exoskeletonChamber1",
			"exo_exoskeletonChamber2",
			"exo_presentation",
			"exo_lab1_primaryConsole",
			"dun_lup_boostLab_laptop"
		}, new Func<string, bool>(a.a))));
	}

	// Token: 0x02000FF7 RID: 4087
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600541B RID: 21531 RVA: 0x00253C08 File Offset: 0x00251E08
		internal bool a(string A_0)
		{
			return this.a.Contains(A_0);
		}

		// Token: 0x04002254 RID: 8788
		public string a;
	}
}
