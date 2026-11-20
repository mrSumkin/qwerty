using System;

// Token: 0x02000C0C RID: 3084
public sealed class b6k : jn
{
	// Token: 0x06004600 RID: 17920 RVA: 0x001C9EDC File Offset: 0x001C80DC
	public b6k() : base("xpbl_otto", "creature\\characters\\xpbl\\otto")
	{
	}

	// Token: 0x06004601 RID: 17921 RVA: 0x001C9EF0 File Offset: 0x001C80F0
	public override string b1(cyt A_0)
	{
		bq8 bq = A_0.e();
		if (bq.GetPrimitivePropertyValue<bool>("quest_killJeteater_completed", new bool?(false)).Value)
		{
			return null;
		}
		bool value = bq.GetPrimitivePropertyValue<bool>("frag_xpbl_ww_jetEater", new bool?(false)).Value;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (!value || serviceOrThrow == null)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_killJeteater_started", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quest_findJetEater_completed", new bool?(false)).Value)
		{
			return "xpbl_dun_cvw_jetEater";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_findJetEater_started", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quest_findJetEater_completed", new bool?(false)).Value)
		{
			return "xpbl_cc-dock2";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_findJetEater_completed", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_findJetEater_started", new bool?(false)).Value && serviceOrThrow.aqw().y8().Equals("xpbl_dun_cvw_jetEater"))
		{
			serviceOrThrow.aqz().atc("cc_otto_findJetEater", true);
			serviceOrThrow.aqz().atb("cc_otto_killJetEater", true);
			A_0.r()["quest_findJetEater_completed"] = true;
			A_0.r()["quest_killJeteater_started"] = true;
			return "xpbl_dun_cvw_jetEater";
		}
		return "cvw20";
	}

	// Token: 0x06004602 RID: 17922 RVA: 0x001CA0A4 File Offset: 0x001C82A4
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			bm6 aspect2 = A_0.GetAspect<bm6>();
			if (string.Equals(A_2, "cvw20", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.e9;
				aspect.aa().HostilityBroadcastMode = c2n.a;
				if (aspect.aa().Vehicle == null)
				{
					b5o b5o = new b5o("xpbl_ScrapJet");
					aspect.a(bln.lx);
					if (b5o != null)
					{
						agt value = new agt(ez2.CreateDefinitonProvider<eqg>("vehicleParts\\Engines\\ScrappyEngine200"));
						agt value2 = new agt(ez2.CreateDefinitonProvider<esd>("vehicleParts\\Batteries\\ScrappyVehicleBattery150"));
						agt value3 = new agt(ez2.CreateDefinitonProvider<eu0>("vehicleParts\\Xpbl_JetskiSuspensions\\XGMist"));
						aspect.aa().Vehicle = new bcx();
						aspect.aa().Vehicle.a(b5o);
						aspect.aa().Vehicle.o()["engine"] = value;
						aspect.aa().Vehicle.o()["battery"] = value2;
						aspect.aa().Vehicle.o()["suspension"] = value3;
						aspect.aa().Vehicle.k();
						aspect.aa().Vehicle.b((double)aspect.aa().Vehicle.v());
						aspect.aa().Vehicle.a(double.MaxValue);
						aspect.aa().Vehicle.k();
						aspect.aa().Portrait = "orb";
						aspect.aa().bl();
						aspect.at();
					}
				}
			}
			if (string.Equals(A_2, "xpbl_dun_cvw_jetEater", StringComparison.OrdinalIgnoreCase) && aspect2 != null)
			{
				aspect2.y6()[ddq.bz] = "player";
				aspect2.y6()[ddq.b0] = 3;
				aspect2.y6().RemoveProperty(ddq.ay);
				aspect2.y6().RemoveProperty(ddq.bg);
			}
		}
	}
}
