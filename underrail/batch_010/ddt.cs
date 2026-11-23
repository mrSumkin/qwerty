using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Game.Fragments;

// Token: 0x020006A7 RID: 1703
[eiz("DEC")]
[Serializable]
public sealed class ddt : dth, ISerializable
{
	// Token: 0x06002C15 RID: 11285 RVA: 0x000FD4D4 File Offset: 0x000FB6D4
	private ddt(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("DEC:I");
		this.b = (DungeonEntrance)A_0.GetValue("DEC:E", typeof(DungeonEntrance));
		this.c = A_0.GetBoolean("DEC:V");
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x000FD52C File Offset: 0x000FB72C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("DEC:I", this.a);
		info.AddValue("DEC:E", this.b);
		info.AddValue("DEC:V", this.c);
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x000FD568 File Offset: 0x000FB768
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x000FD570 File Offset: 0x000FB770
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C19 RID: 11289 RVA: 0x000FD57C File Offset: 0x000FB77C
	public DungeonEntrance a()
	{
		return this.b;
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x000FD584 File Offset: 0x000FB784
	public void a(DungeonEntrance A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002C1B RID: 11291 RVA: 0x000FD590 File Offset: 0x000FB790
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x000FD598 File Offset: 0x000FB798
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002C1D RID: 11293 RVA: 0x000FD5A4 File Offset: 0x000FB7A4
	public ddt()
	{
	}

	// Token: 0x06002C1E RID: 11294 RVA: 0x000FD5B0 File Offset: 0x000FB7B0
	public bool jh(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		string text;
		if (!string.IsNullOrEmpty(this.a))
		{
			text = this.a;
		}
		else
		{
			if (serviceOrThrow.aqu() == null || serviceOrThrow.aqu().c() == null)
			{
				return false;
			}
			text = serviceOrThrow.aqu().c().b();
		}
		if (!string.IsNullOrEmpty(text) && serviceOrThrow.aqu() != null)
		{
			DungeonEntrance? primitivePropertyValue = ((bq8)serviceOrThrow.aqu().e()).GetPrimitivePropertyValue<DungeonEntrance>(string.Format("dungeon_{0}_entrance", text), null);
			if (primitivePropertyValue != null)
			{
				DungeonEntrance? dungeonEntrance = primitivePropertyValue;
				DungeonEntrance dungeonEntrance2 = this.b;
				return (dungeonEntrance.GetValueOrDefault() == dungeonEntrance2 & dungeonEntrance != null) ^ this.c;
			}
		}
		return false;
	}

	// Token: 0x06002C1F RID: 11295 RVA: 0x000FD680 File Offset: 0x000FB880
	public string ji()
	{
		string arg;
		if (!string.IsNullOrEmpty(this.a))
		{
			arg = string.Format("Вход в подземелье \"{0}\"", this.a);
		}
		else
		{
			arg = "Вход в подземелье";
		}
		if (this.c)
		{
			return string.Format("{0} входит через запасной вход в {1}", arg, this.b);
		}
		return string.Format("{0} входит в {1}", arg, this.b);
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x000FD6F4 File Offset: 0x000FB8F4
	public override string ToString()
	{
		return this.ji();
	}

	// Token: 0x0400191C RID: 6428
	private string a;

	// Token: 0x0400191D RID: 6429
	private DungeonEntrance b;

	// Token: 0x0400191E RID: 6430
	private bool c;
}
