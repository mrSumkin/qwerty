using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B17 RID: 2839
[eiz("XPBLSCAJ")]
[Serializable]
public sealed class qj : cze, ISerializable
{
	// Token: 0x06004198 RID: 16792 RVA: 0x00193C40 File Offset: 0x00191E40
	private qj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("XPBLSCAJ:IT");
		this.b = (A_0.GetValue("XPBLSCAJ:BN", typeof(int?)) as int?);
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x00193C8C File Offset: 0x00191E8C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLSCAJ:IT", this.a);
		info.AddValue("XPBLSCAJ:BN", this.b);
	}

	// Token: 0x0600419A RID: 16794 RVA: 0x00193CC0 File Offset: 0x00191EC0
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600419B RID: 16795 RVA: 0x00193CC8 File Offset: 0x00191EC8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600419C RID: 16796 RVA: 0x00193CD4 File Offset: 0x00191ED4
	public int? b()
	{
		return this.b;
	}

	// Token: 0x0600419D RID: 16797 RVA: 0x00193CDC File Offset: 0x00191EDC
	public void a(int? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600419E RID: 16798 RVA: 0x00193CE8 File Offset: 0x00191EE8
	public qj()
	{
	}

	// Token: 0x0600419F RID: 16799 RVA: 0x00193CF0 File Offset: 0x00191EF0
	public qj(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060041A0 RID: 16800 RVA: 0x00193D00 File Offset: 0x00191F00
	public qj(int A_0)
	{
		this.b = new int?(A_0);
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x00193D14 File Offset: 0x00191F14
	public qj(string A_0, int A_1)
	{
		this.a = A_0;
		this.b = new int?(A_1);
	}

	// Token: 0x060041A2 RID: 16802 RVA: 0x00193D30 File Offset: 0x00191F30
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bu6 service = bpo.GetService<bu6>();
		if (serviceOrThrow != null && service != null)
		{
			serviceOrThrow.aqu().r()["loc_xpbl_camp_underAttack"] = true;
			new abb().ym(null, null, null);
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value;
			if (this.a == null || this.a == "Sormirbaren")
			{
				serviceOrThrow.aqu().r()["loc_xpbl_e5_invadersType"] = "Sormirbaren";
				this.a(serviceOrThrow);
				if (this.b != null)
				{
					num = this.b.Value;
				}
				else
				{
					num++;
				}
				serviceOrThrow.aqu().r()["loc_xpbl_e5_battleNumber"] = num;
				if (num == 1)
				{
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						this.a(serviceOrThrow, 9, 3, 2, 4);
						return;
					}
					if (service.aq2() >= GameDifficulty.Hard)
					{
						this.a(serviceOrThrow, 9, 3, 2, 0);
						return;
					}
					if (service.aq2() == GameDifficulty.Normal)
					{
						this.a(serviceOrThrow, 9, 3, 2, 0);
						return;
					}
					this.a(serviceOrThrow, 7, 3, 3, 0);
					return;
				}
				else if (num == 2)
				{
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						this.a(serviceOrThrow, 10, 4, 2, 9);
						return;
					}
					if (service.aq2() >= GameDifficulty.Hard)
					{
						this.a(serviceOrThrow, 9, 4, 2, 7);
						return;
					}
					if (service.aq2() == GameDifficulty.Normal)
					{
						this.a(serviceOrThrow, 9, 3, 2, 6);
						return;
					}
					this.a(serviceOrThrow, 8, 3, 3, 5);
					return;
				}
				else if (num == 3)
				{
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						this.a(serviceOrThrow, 11, 4, 2, 11);
						return;
					}
					if (service.aq2() >= GameDifficulty.Hard)
					{
						this.a(serviceOrThrow, 10, 4, 2, 9);
						return;
					}
					if (service.aq2() == GameDifficulty.Normal)
					{
						this.a(serviceOrThrow, 9, 3, 2, 8);
						return;
					}
					this.a(serviceOrThrow, 9, 3, 3, 6);
					return;
				}
				else if (num == 4)
				{
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						this.a(serviceOrThrow, 11, 5, 2, 15);
						return;
					}
					if (service.aq2() >= GameDifficulty.Hard)
					{
						this.a(serviceOrThrow, 11, 5, 2, 14);
						return;
					}
					if (service.aq2() == GameDifficulty.Normal)
					{
						this.a(serviceOrThrow, 10, 4, 2, 12);
						return;
					}
					this.a(serviceOrThrow, 9, 3, 3, 8);
					return;
				}
				else if (num >= 5)
				{
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						this.a(serviceOrThrow, 12, 5, 2, 19);
						return;
					}
					if (service.aq2() >= GameDifficulty.Hard)
					{
						this.a(serviceOrThrow, 11, 5, 2, 17);
						return;
					}
					if (service.aq2() == GameDifficulty.Normal)
					{
						this.a(serviceOrThrow, 10, 5, 2, 14);
						return;
					}
					this.a(serviceOrThrow, 9, 4, 3, 10);
					return;
				}
			}
			else
			{
				if (service.aq2() >= GameDifficulty.Dominating)
				{
					this.a(serviceOrThrow, 10, 4, 2, 0);
				}
				else if (service.aq2() >= GameDifficulty.Hard)
				{
					this.a(serviceOrThrow, 9, 4, 2, 0);
				}
				else if (service.aq2() == GameDifficulty.Normal)
				{
					this.a(serviceOrThrow, 9, 3, 2, 0);
				}
				else
				{
					this.a(serviceOrThrow, 8, 3, 3, 0);
				}
				serviceOrThrow.aqu().r()["loc_xpbl_e5_invadersType"] = this.a;
			}
		}
	}

	// Token: 0x060041A3 RID: 16803 RVA: 0x00194084 File Offset: 0x00192284
	private void a(cnk A_0, int A_1, int A_2, int A_3, int A_4)
	{
		if (A_0.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_campHasMines", new bool?(false)).Value)
		{
			if (A_4 > 0)
			{
				A_4 -= A_4 / A_2 * 2;
			}
			A_2 -= 2;
			new beg(false).ym(null, null, null);
			A_0.aqu().b(new c6d());
		}
		A_0.aqu().r()["loc_xpbl_e5_numberOfSpecialAttackers"] = A_4;
		A_0.aqu().r()["loc_xpbl_e5_numberOfInvaders"] = A_1;
		A_0.aqu().r()["loc_xpbl_e5_numberOfWaves"] = A_2;
		A_0.aqu().r()["loc_xpbl_e5_turnsBetweenWaves"] = A_3;
		A_0.aqu().r()["loc_xpbl_e5_allInvadersKilled"] = false;
	}

	// Token: 0x060041A4 RID: 16804 RVA: 0x00194178 File Offset: 0x00192378
	private void a(cnk A_0)
	{
		List<string> list;
		if (cuo.a.Next(0, 2) != 0)
		{
			list = new List<string>
			{
				"xpbl_c7",
				"xpbl_e7",
				"xpbl_f6"
			};
		}
		else
		{
			list = new List<string>
			{
				"xpbl_d7",
				"xpbl_f7",
				"xpbl_f5"
			};
		}
		foreach (string a_ in list)
		{
			A_0.aqu().a(new bw0(a_, new erw(true), 1));
			new dvn(a_, "xpbl_SavagesBattle").ym(null, null, null);
		}
	}

	// Token: 0x04001C16 RID: 7190
	private new string a;

	// Token: 0x04001C17 RID: 7191
	private int? b;
}
