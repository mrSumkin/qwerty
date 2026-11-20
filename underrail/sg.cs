using System;
using System.Collections.Generic;

// Token: 0x020007CA RID: 1994
public static class sg
{
	// Token: 0x0600320A RID: 12810 RVA: 0x0013290C File Offset: 0x00130B0C
	public static List<string> a(string A_0, out int A_1, out int A_2)
	{
		List<string> result = null;
		A_1 = 0;
		A_2 = sg.c(A_0);
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 6:
			{
				char c = A_0[0];
				if (c != 'r')
				{
					if (c == 'w')
					{
						if (A_0 == "wep.ak")
						{
							result = new List<string>
							{
								"assaultRifleFrame2"
							};
							A_1 = 120;
						}
					}
				}
				else if (A_0 == "rancor")
				{
					result = new List<string>
					{
						"combatShotgunFrame3"
					};
					A_1 = 135;
				}
				break;
			}
			case 7:
			{
				char c = A_0[5];
				if (c <= '9')
				{
					if (c != '1')
					{
						switch (c)
						{
						case '6':
							if (A_0 == "wep.m60")
							{
								result = new List<string>
								{
									"lmgFrame4",
									"lmgBeltMag80"
								};
								A_1 = 130;
							}
							break;
						case '7':
							if (!(A_0 == "wep.m79"))
							{
							}
							break;
						case '9':
							if (A_0 == "wep.p90")
							{
								result = new List<string>
								{
									"smgFrame4"
								};
								A_1 = 125;
							}
							break;
						}
					}
					else if (A_0 == "wep.m16")
					{
						result = new List<string>
						{
							"assaultRifleFrame1"
						};
						A_1 = 130;
					}
				}
				else if (c != 'g')
				{
					if (c == 'w')
					{
						if (A_0 == "wep.awf")
						{
							result = new List<string>
							{
								"sniperFrame3",
								"rifleBipod"
							};
							A_1 = 120;
						}
					}
				}
				else if (A_0 == "wep.mg3")
				{
					result = new List<string>
					{
						"lmgFrame3",
						"ergonomicHandle",
						"lmgBeltMag100"
					};
					A_1 = 120;
				}
				break;
			}
			case 8:
			{
				char c = A_0[4];
				if (c != 'c')
				{
					if (c != 'g')
					{
						if (c == 'x')
						{
							if (A_0 == "wep.xm25")
							{
								result = new List<string>
								{
									"grenadeLauncherFrame4",
									"grenadeLauncherBarrel25L",
									"grenadeLauncherBoxMagazine10"
								};
								A_1 = 130;
							}
						}
					}
					else if (A_0 == "wep.gShG")
					{
						result = new List<string>
						{
							"minigun.destroyer.frame",
							"lmgBeltMag100",
							"minigunMotorJumpstarter2"
						};
						A_1 = 125;
					}
				}
				else if (A_0 == "wep.cz99")
				{
					result = new List<string>
					{
						"pistolFrame4",
						"rapidReloader"
					};
					A_1 = 110;
				}
				break;
			}
			case 9:
				if (A_0 == "wep.hk416")
				{
					result = new List<string>
					{
						"assaultRifleFrame1",
						"forwardGrip",
						"scope"
					};
					A_1 = 120;
				}
				break;
			case 10:
			{
				char c = A_0[7];
				if (c <= '7')
				{
					if (c != '0')
					{
						if (c != '5')
						{
							if (c == '7')
							{
								if (A_0 == "wep.rpg7v2")
								{
									result = new List<string>
									{
										"airburstScope",
										"rocketLauncherFiringMechanism2"
									};
								}
							}
						}
						else if (A_0 == "wep.fn2500")
						{
							result = new List<string>
							{
								"assaultRifleFrame3",
								"rapidReloader"
							};
							A_1 = 135;
						}
					}
					else if (A_0 == "wep.tt3000")
					{
						result = new List<string>
						{
							"pistolFrame1",
							"laserSight"
						};
						A_1 = 110;
					}
				}
				else if (c != 'M')
				{
					switch (c)
					{
					case 'k':
						if (A_0 == "wep.milkor")
						{
							result = new List<string>
							{
								"grenadeLauncherFrame1",
								"grenadeLauncherScope",
								"grenadeLauncherRevolverCylinder8"
							};
							A_1 = 125;
						}
						break;
					case 'l':
						break;
					case 'm':
						if (A_0 == "weapon.mp5")
						{
							result = new List<string>
							{
								"smgFrame2",
								"muzzleBrake"
							};
							A_1 = 115;
						}
						break;
					case 'n':
						if (!(A_0 == "wep.magnum"))
						{
						}
						break;
					default:
						if (c == 'u')
						{
							if (A_0 == "weapon.uzi")
							{
								result = new List<string>
								{
									"smgFrame3",
									"rapidReloader"
								};
								A_1 = 100;
							}
						}
						break;
					}
				}
				else if (A_0 == "wep.sigMPX")
				{
					result = new List<string>
					{
						"smgFrame2",
						"extendedPistolMagazine",
						"laserSight"
					};
					A_1 = 125;
				}
				break;
			}
			case 11:
			{
				char c = A_0[4];
				if (c <= 'b')
				{
					if (c != 'a')
					{
						if (c == 'b')
						{
							if (A_0 == "wep.brenLMG")
							{
								result = new List<string>
								{
									"lmgFrame1",
									"lmgBoxMag65",
									"muzzleBrake"
								};
								A_1 = 115;
							}
						}
					}
					else if (A_0 == "salvation13")
					{
						result = new List<string>
						{
							"combatShotgunFrame2"
						};
						A_1 = 135;
					}
				}
				else if (c != 'g')
				{
					if (c == 's')
					{
						if (A_0 == "wep.srrch42")
						{
							result = new List<string>
							{
								"smgFrame4"
							};
							A_1 = 115;
						}
					}
				}
				else if (A_0 == "wep.glock17")
				{
					result = new List<string>
					{
						"pistolFrame4",
						"extendedPistolMagazine",
						"rapidReloader"
					};
					A_1 = 120;
				}
				break;
			}
			case 12:
			{
				char c = A_0[4];
				if (c != 'd')
				{
					if (c == 's')
					{
						if (A_0 == "wep.steyrAug")
						{
							result = new List<string>
							{
								"assaultRifleFrame3",
								"extendedRifleMagazine"
							};
							A_1 = 135;
						}
					}
				}
				else if (A_0 == "wep.dragunov")
				{
					result = new List<string>
					{
						"sniperFrame4",
						"highResolutionDigitalScope"
					};
					A_1 = 110;
				}
				break;
			}
			case 13:
			{
				char c = A_0[4];
				if (c != 'b')
				{
					if (c == 'm')
					{
						if (A_0 == "wep.m202flash")
						{
							result = new List<string>
							{
								"supersteel",
								"grenadeLauncherScope",
								"forwardGrip"
							};
							A_1 = 110;
						}
					}
				}
				else if (A_0 == "wep.beretta99")
				{
					result = new List<string>
					{
						"pistolFrame3",
						"extendedPistolMagazine",
						"silencer"
					};
					A_1 = 110;
				}
				break;
			}
			case 14:
			{
				char c = A_0[4];
				if (c != 'a')
				{
					if (c == 'b')
					{
						if (A_0 == "wep.blackArrow")
						{
							result = new List<string>
							{
								"sniperFrame2",
								"supersteel"
							};
							A_1 = 145;
						}
					}
				}
				else if (A_0 == "wep.alcotan100")
				{
					result = new List<string>
					{
						"rocketLauncherFrame5",
						"rocketLauncherEmrac"
					};
					A_1 = 130;
				}
				break;
			}
			case 15:
			{
				char c = A_0[2];
				if (c != 'a')
				{
					if (c == 'p')
					{
						if (A_0 == "wep.desertEagle")
						{
							result = new List<string>
							{
								"pistolFrame2"
							};
							A_1 = 125;
						}
					}
				}
				else if (A_0 == "weapon.tommyGun")
				{
					result = new List<string>
					{
						"smgFrame4",
						"barrelCompensator"
					};
					A_1 = 120;
				}
				break;
			}
			case 21:
				if (!(A_0 == "doubleBarreledShotgun"))
				{
				}
				break;
			}
		}
		return result;
	}

	// Token: 0x0600320B RID: 12811 RVA: 0x00133258 File Offset: 0x00131458
	public static int c(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = 0;
		if (serviceOrThrow != null)
		{
			coh coh = serviceOrThrow.aqu().v().a(A_0, true);
			if (coh != null)
			{
				int num2 = 6000 + (int)(coh.Definition.bf() / (double)2 + (double)(coh.Definition.a8() * 600)).Value;
				if (sg.b(sg.a(A_0)))
				{
					num2 = (int)((float)num2 * 0.6f);
				}
				num = num2 / 30;
				num = num / 100 * 100;
			}
		}
		return num;
	}

	// Token: 0x0600320C RID: 12812 RVA: 0x00133344 File Offset: 0x00131544
	public static bool b(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasAllSchematics", new bool?(false)).Value)
			{
				return true;
			}
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasPistolSmgSchematics", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasRifleShotgunSchematics", new bool?(false)).Value;
			bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasMachineGunSchematics", new bool?(false)).Value;
			bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasGrenadeLauncherSchematics", new bool?(false)).Value;
			if (!string.IsNullOrWhiteSpace(A_0))
			{
				if ((A_0 == "Pistol" || A_0 == "SMG") && value)
				{
					return true;
				}
				if ((A_0.Contains("Rifle") || A_0.Contains("Shotgun")) && value2)
				{
					return true;
				}
				if (A_0.Contains("Machine Gun") && value3)
				{
					return true;
				}
				if (A_0.Contains("Launcher") && value4)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600320D RID: 12813 RVA: 0x001334A8 File Offset: 0x001316A8
	public static string a(string A_0)
	{
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 6:
			{
				char c = A_0[0];
				if (c != 'r')
				{
					if (c == 'w')
					{
						if (A_0 == "wep.ak")
						{
							return "Assault Rifle";
						}
					}
				}
				else if (A_0 == "rancor")
				{
					return "Combat Shotgun";
				}
				break;
			}
			case 7:
			{
				char c = A_0[5];
				if (c <= '9')
				{
					if (c != '1')
					{
						switch (c)
						{
						case '6':
							if (A_0 == "wep.m60")
							{
								return "Machine Gun";
							}
							break;
						case '7':
							if (A_0 == "wep.m79")
							{
								return "Grenade Launcher";
							}
							break;
						case '9':
							if (A_0 == "wep.p90")
							{
								return "SMG";
							}
							break;
						}
					}
					else if (A_0 == "wep.m16")
					{
						return "Assault Rifle";
					}
				}
				else if (c != 'g')
				{
					if (c == 'w')
					{
						if (A_0 == "wep.awf")
						{
							return "Sniper Rifle";
						}
					}
				}
				else if (A_0 == "wep.mg3")
				{
					return "Machine Gun";
				}
				break;
			}
			case 8:
			{
				char c = A_0[4];
				if (c != 'c')
				{
					if (c != 'g')
					{
						if (c == 'x')
						{
							if (A_0 == "wep.xm25")
							{
								return "Grenade Launcher";
							}
						}
					}
					else if (A_0 == "wep.gShG")
					{
						return "Rotary Machine Gun";
					}
				}
				else if (A_0 == "wep.cz99")
				{
					return "Pistol";
				}
				break;
			}
			case 9:
				if (A_0 == "wep.hk416")
				{
					return "Assault Rifle";
				}
				break;
			case 10:
			{
				char c = A_0[7];
				if (c <= '7')
				{
					if (c != '0')
					{
						if (c != '5')
						{
							if (c == '7')
							{
								if (A_0 == "wep.rpg7v2")
								{
									return "Rocket Launcher";
								}
							}
						}
						else if (A_0 == "wep.fn2500")
						{
							return "Assault Rifle";
						}
					}
					else if (A_0 == "wep.tt3000")
					{
						return "Pistol";
					}
				}
				else if (c != 'M')
				{
					switch (c)
					{
					case 'k':
						if (A_0 == "wep.milkor")
						{
							return "Grenade Launcher";
						}
						break;
					case 'l':
						break;
					case 'm':
						if (A_0 == "weapon.mp5")
						{
							return "SMG";
						}
						break;
					case 'n':
						if (A_0 == "wep.magnum")
						{
							return "Pistol";
						}
						break;
					default:
						if (c == 'u')
						{
							if (A_0 == "weapon.uzi")
							{
								return "SMG";
							}
						}
						break;
					}
				}
				else if (A_0 == "wep.sigMPX")
				{
					return "SMG";
				}
				break;
			}
			case 11:
			{
				char c = A_0[4];
				if (c <= 'b')
				{
					if (c != 'a')
					{
						if (c == 'b')
						{
							if (A_0 == "wep.brenLMG")
							{
								return "Machine Gun";
							}
						}
					}
					else if (A_0 == "salvation13")
					{
						return "Combat Shotgun";
					}
				}
				else if (c != 'g')
				{
					if (c == 's')
					{
						if (A_0 == "wep.srrch42")
						{
							return "SMG";
						}
					}
				}
				else if (A_0 == "wep.glock17")
				{
					return "Pistol";
				}
				break;
			}
			case 12:
			{
				char c = A_0[4];
				if (c != 'd')
				{
					if (c == 's')
					{
						if (A_0 == "wep.steyrAug")
						{
							return "Assault Rifle";
						}
					}
				}
				else if (A_0 == "wep.dragunov")
				{
					return "Sniper Rifle";
				}
				break;
			}
			case 13:
			{
				char c = A_0[4];
				if (c != 'b')
				{
					if (c == 'm')
					{
						if (A_0 == "wep.m202flash")
						{
							return "Rocket Launcher";
						}
					}
				}
				else if (A_0 == "wep.beretta99")
				{
					return "Pistol";
				}
				break;
			}
			case 14:
			{
				char c = A_0[4];
				if (c != 'a')
				{
					if (c == 'b')
					{
						if (A_0 == "wep.blackArrow")
						{
							return "Sniper Rifle";
						}
					}
				}
				else if (A_0 == "wep.alcotan100")
				{
					return "Rocket Launcher";
				}
				break;
			}
			case 15:
			{
				char c = A_0[2];
				if (c != 'a')
				{
					if (c == 'p')
					{
						if (A_0 == "wep.desertEagle")
						{
							return "Pistol";
						}
					}
				}
				else if (A_0 == "weapon.tommyGun")
				{
					return "SMG";
				}
				break;
			}
			case 21:
				if (A_0 == "doubleBarreledShotgun")
				{
					return "Shotgun";
				}
				break;
			}
		}
		return null;
	}

	// Token: 0x04001AD9 RID: 6873
	public static readonly List<string> a = new List<string>
	{
		"wep.ak",
		"wep.awf",
		"wep.beretta99",
		"wep.blackArrow",
		"wep.cz99",
		"wep.desertEagle",
		"wep.dragunov",
		"wep.fn2500",
		"wep.glock17",
		"wep.hk416",
		"wep.m16",
		"wep.magnum",
		"weapon.mp5",
		"wep.p90",
		"wep.sigMPX",
		"wep.steyrAug",
		"weapon.tommyGun",
		"wep.tt3000",
		"weapon.uzi",
		"doubleBarreledShotgun",
		"rancor",
		"wep.srrch42",
		"salvation13",
		"wep.m60",
		"wep.mg3",
		"wep.brenLMG",
		"wep.gShG",
		"wep.m79",
		"wep.milkor",
		"wep.xm25",
		"wep.m202flash",
		"wep.alcotan100",
		"wep.rpg7v2"
	};
}
