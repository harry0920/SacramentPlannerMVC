﻿using SacramentPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlannerMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            context.Database.EnsureCreated();

            if (context.Bishopric.Any())
            {
                return;
            }

            var bishoprics = new Bishopric[]
            {
                new Bishopric{Name="Brother Thayne",IsActive=true},
                new Bishopric{Name="Zach Wilson",IsActive=true},
                new Bishopric{Name="TadCooper",IsActive=true}
            };
            foreach (Bishopric b in bishoprics)
            {
                context.Bishopric.Add(b);
            }

            /*
            var members = new Member[]
            {
              new Member{ FirstMidName="Bobbi"     ,LastName= "Paddock"       },     
              new Member{ FirstMidName="Darcel"    ,LastName= "Okeeffe"       },
              new Member{ FirstMidName="Kathyrn"   ,LastName= "Summey"        },
              new Member{ FirstMidName="Divina"    ,LastName= "Rollin"        },
              new Member{ FirstMidName="Chad"      ,LastName= "Witten"        },
              new Member{ FirstMidName="Nathaniel" ,LastName= "Straughan"     },
              new Member{ FirstMidName="Annamarie" ,LastName= "Gleaton"       },
              new Member{ FirstMidName="Marielle"  ,LastName= "Ransome"       },
              new Member{ FirstMidName="Edythe"    ,LastName= "Khalaf"        },
              new Member{ FirstMidName="Gerardo"   ,LastName= "Odem"          },
              new Member{ FirstMidName="Jennefer"  ,LastName= "Addison"       },
              new Member{ FirstMidName="Suzie"     ,LastName= "Camara"        },
              new Member{ FirstMidName="Neely"     ,LastName= "Hornstein"     },
              new Member{ FirstMidName="Jessica"   ,LastName= "Parkinson"     },
              new Member{ FirstMidName="Lael"      ,LastName= "Riggs"         },
              new Member{ FirstMidName="Horacio"   ,LastName= "Bernardino"    },
              new Member{ FirstMidName="Louise"    ,LastName= "Tindell"       },
              new Member{ FirstMidName="Brittaney" ,LastName= "Lansing"       },
              new Member{ FirstMidName="Cordia"    ,LastName= "Shadwick"      },
              new Member{ FirstMidName="Dovie"     ,LastName= "Guerrero"      },
              new Member{ FirstMidName="Lorean"    ,LastName= "Romano"        },
              new Member{ FirstMidName="Marni"     ,LastName= "Almada"        },
              new Member{ FirstMidName="Leora"     ,LastName= "Low"           },
              new Member{ FirstMidName="Alfonzo"   ,LastName= "Duppstadt"     },
              new Member{ FirstMidName="Rosalee"   ,LastName= "Christofferso" },
              new Member{ FirstMidName="Pandora"   ,LastName= "Kist"          },
              new Member{ FirstMidName="Hubert"    ,LastName= "Siegel"        },
              new Member{ FirstMidName="Virgina"   ,LastName= "Agrawal"       },
              new Member{ FirstMidName="Yahaira"   ,LastName= "Diener"        },
              new Member{ FirstMidName="Salvatore" ,LastName= "Bickham"       }
            };

            foreach (Member b in members)
            {
                context.Members.Add(b);
            } */

            var hymns = new Hymn[]
            {
                new Hymn{ HymnID=1   , HymnTitle="The Morning Breaks                               "},
                new Hymn{ HymnID=2   , HymnTitle="The Spirit of God                                "},
                new Hymn{ HymnID=3   , HymnTitle="Now Let Us Rejoice                               "},
                new Hymn{ HymnID=4   , HymnTitle="Truth Eternal                                    "},
                new Hymn{ HymnID=5   , HymnTitle="High on the Mountain Top                         "},
                new Hymn{ HymnID=6   , HymnTitle="Redeemer of Israel                               "},
                new Hymn{ HymnID=7   , HymnTitle="Israel, Israel, God Is Calling                   "},
                new Hymn{ HymnID=8   , HymnTitle="Awake and Arise                                  "},
                new Hymn{ HymnID=9   , HymnTitle="Come, Rejoice                                    "},
                new Hymn{ HymnID=10  , HymnTitle="Come, Sing to the Lord                           "},
                new Hymn{ HymnID=11  , HymnTitle="What Was Witnessed in the Heavens?               "},
                new Hymn{ HymnID=12  , HymnTitle="’Twas Witnessed in the Morning Sky               "},
                new Hymn{ HymnID=13  , HymnTitle="An Angel from on High                            "},
                new Hymn{ HymnID=14  , HymnTitle="Sweet Is the Peace the Gospel Brings             "},
                new Hymn{ HymnID=15  , HymnTitle="I Saw a Mighty Angel Fly                         "},
                new Hymn{ HymnID=16  , HymnTitle="What Glorious Scenes Mine Eyes Behold            "},
                new Hymn{ HymnID=17  , HymnTitle="Awake, Ye Saints of God, Awake!                  "},
                new Hymn{ HymnID=18  , HymnTitle="The Voice of God Again Is Heard                  "},
                new Hymn{ HymnID=19  , HymnTitle="We Thank Thee, O God, for a Prophet              "},
                new Hymn{ HymnID=20  , HymnTitle="God of Power, God of Right                       "},
                new Hymn{ HymnID=21  , HymnTitle="Come, Listen to a Prophet’s Voice                "},
                new Hymn{ HymnID=22  , HymnTitle="We Listen to a Prophet’s Voice                   "},
                new Hymn{ HymnID=23  , HymnTitle="We Ever Pray for Thee                            "},
                new Hymn{ HymnID=24  , HymnTitle="God Bless Our Prophet Dear                       "},
                new Hymn{ HymnID=25  , HymnTitle="Now We’ll Sing with One Accord                   "},
                new Hymn{ HymnID=26  , HymnTitle="Joseph Smith’s First Prayer                      "},
                new Hymn{ HymnID=27  , HymnTitle="Praise to the Man                                "},
                new Hymn{ HymnID=28  , HymnTitle="Saints, Behold How Great Jehovah                 "},
                new Hymn{ HymnID=29  , HymnTitle="A Poor Wayfaring Man of Grief                    "},
                new Hymn{ HymnID=30  , HymnTitle="Come, Come, Ye Saints                            "},
                new Hymn{ HymnID=31  , HymnTitle="O God, Our Help in Ages Past                     "},
                new Hymn{ HymnID=32  , HymnTitle="The Happy Day at Last Has Come                   "},
                new Hymn{ HymnID=33  , HymnTitle="Our Mountain Home So Dear                        "},
                new Hymn{ HymnID=34  , HymnTitle="O Ye Mountains High                              "},
                new Hymn{ HymnID=35  , HymnTitle="For the Strength of the Hills                    "},
                new Hymn{ HymnID=36  , HymnTitle="They, the Builders of the Nation                 "},
                new Hymn{ HymnID=37  , HymnTitle="The Wintry Day, Descending to Its Close          "},
                new Hymn{ HymnID=38  , HymnTitle="Come, All Ye Saints of Zion                      "},
                new Hymn{ HymnID=39  , HymnTitle="O Saints of Zion                                 "},
                new Hymn{ HymnID=40  , HymnTitle="Arise, O Glorious Zion                           "},
                new Hymn{ HymnID=41  , HymnTitle="Let Zion in Her Beauty Rise                      "},
                new Hymn{ HymnID=42  , HymnTitle="Hail to the Brightness of Zion's Glad Morning!   "},
                new Hymn{ HymnID=43  , HymnTitle="Zion Stands with Hills Surrounded                "},
                new Hymn{ HymnID=44  , HymnTitle="Beautiful Zion, Built Above                      "},
                new Hymn{ HymnID=45  , HymnTitle="Lead Me into Life Eternal                        "},
                new Hymn{ HymnID=46  , HymnTitle="Glorious Things of Thee Are Spoken               "},
                new Hymn{ HymnID=47  , HymnTitle="We Will Sing of Zion                             "},
                new Hymn{ HymnID=48  , HymnTitle="Glorious Things Are Sung of Zion                 "},
                new Hymn{ HymnID=49  , HymnTitle="Adam-ondi-Ahman                                  "},
                new Hymn{ HymnID=50  , HymnTitle="Come, Thou Glorious Day of Promise               "},
                new Hymn{ HymnID=51  , HymnTitle="Sons of Michael, He Approaches                   "},
                new Hymn{ HymnID=52  , HymnTitle="The Day Dawn Is Breaking                         "},
                new Hymn{ HymnID=53  , HymnTitle="Let Earth’s Inhabitants Rejoice                  "},
                new Hymn{ HymnID=54  , HymnTitle="Behold, the Mountain of the Lord                 "},
                new Hymn{ HymnID=55  , HymnTitle="Lo, the Mighty God Appearing!                    "},
                new Hymn{ HymnID=56  , HymnTitle="Softly Beams the Sacred Dawning                  "},
                new Hymn{ HymnID=57  , HymnTitle="We’re Not Ashamed to Own Our Lord                "},
                new Hymn{ HymnID=58  , HymnTitle="Come, Ye Children of the Lord                    "},
                new Hymn{ HymnID=59  , HymnTitle="Come, O Thou King of Kings                       "},
                new Hymn{ HymnID=60  , HymnTitle="Battle Hymn of the Republic                      "},
                new Hymn{ HymnID=61  , HymnTitle="Raise Your Voices to the Lord                    "},
                new Hymn{ HymnID=62  , HymnTitle="All Creatures of Our God and King                "},
                new Hymn{ HymnID=63  , HymnTitle="Great King of Heaven                             "},
                new Hymn{ HymnID=64  , HymnTitle="On This Day of Joy and Gladness                  "},
                new Hymn{ HymnID=65  , HymnTitle="Come, All Ye Saints Who Dwell on Earth           "},
                new Hymn{ HymnID=66  , HymnTitle="Rejoice, the Lord Is King!                       "},
                new Hymn{ HymnID=67  , HymnTitle="Glory to God on High                             "},
                new Hymn{ HymnID=68  , HymnTitle="A Mighty Fortress Is Our God                     "},
                new Hymn{ HymnID=69  , HymnTitle="All Glory, Laud, and Honor                       "},
                new Hymn{ HymnID=70  , HymnTitle="Sing Praise to Him                               "},
                new Hymn{ HymnID=71  , HymnTitle="With Songs of Praise                             "},
                new Hymn{ HymnID=72  , HymnTitle="Praise to the Lord, the Almighty                 "},
                new Hymn{ HymnID=73  , HymnTitle="Praise the Lord with Heart and Voice             "},
                new Hymn{ HymnID=74  , HymnTitle="Praise Ye the Lord                               "},
                new Hymn{ HymnID=75  , HymnTitle="In Hymns of Praise                               "},
                new Hymn{ HymnID=76  , HymnTitle="God of Our Fathers, We Come unto Thee            "},
                new Hymn{ HymnID=77  , HymnTitle="Great Is the Lord                                "},
                new Hymn{ HymnID=78  , HymnTitle="God of Our Fathers, Whose Almighty Hand          "},
                new Hymn{ HymnID=79  , HymnTitle="With All the Power of Heart and Tongue           "},
                new Hymn{ HymnID=80  , HymnTitle="God of Our Fathers, Known of Old                 "},
                new Hymn{ HymnID=81  , HymnTitle="Press Forward, Saints                            "},
                new Hymn{ HymnID=82  , HymnTitle="For All the Saints                               "},
                new Hymn{ HymnID=83  , HymnTitle="Guide Us, O Thou Great Jehovah                   "},
                new Hymn{ HymnID=84  , HymnTitle="Faith of Our Fathers                             "},
                new Hymn{ HymnID=85  , HymnTitle="How Firm a Foundation                            "},
                new Hymn{ HymnID=86  , HymnTitle="How Great Thou Art                               "},
                new Hymn{ HymnID=87  , HymnTitle="God Is Love                                      "},
                new Hymn{ HymnID=88  , HymnTitle="Great God, Attend While Zion Sings               "},
                new Hymn{ HymnID=89  , HymnTitle="The Lord Is My Light                             "},
                new Hymn{ HymnID=90  , HymnTitle="From All That Dwell below the Skies              "},
                new Hymn{ HymnID=91  , HymnTitle="Father, Thy Children to Thee Now Raise           "},
                new Hymn{ HymnID=92  , HymnTitle="For the Beauty of the Earth                      "},
                new Hymn{ HymnID=93  , HymnTitle="Prayer of Thanksgiving                           "},
                new Hymn{ HymnID=94  , HymnTitle="Come, Ye Thankful People                         "},
                new Hymn{ HymnID=95  , HymnTitle="Now Thank We All Our God                         "},
                new Hymn{ HymnID=96  , HymnTitle="Dearest Children, God Is Near You                "},
                new Hymn{ HymnID=97  , HymnTitle="Lead, Kindly Light                               "},
                new Hymn{ HymnID=98  , HymnTitle="I Need Thee Every Hour                           "},
                new Hymn{ HymnID=99  , HymnTitle="Nearer, Dear Savior, to Thee                     "},
                new Hymn{ HymnID=100 , HymnTitle="Nearer, My God, to Thee                          "},
                new Hymn{ HymnID=101 , HymnTitle="Guide Me to Thee                                 "},
                new Hymn{ HymnID=102 , HymnTitle="Jesus, Lover of My Soul                          "},
                new Hymn{ HymnID=103 , HymnTitle="Precious Savior, Dear Redeemer                   "},
                new Hymn{ HymnID=104 , HymnTitle="Jesus, Savior, Pilot Me                          "},
                new Hymn{ HymnID=105 , HymnTitle="Master, the Tempest Is Raging                    "},
                new Hymn{ HymnID=106 , HymnTitle="God Speed the Right                              "},
                new Hymn{ HymnID=107 , HymnTitle="Lord, Accept Our True Devotion                   "},
                new Hymn{ HymnID=108 , HymnTitle="The Lord Is My Shepherd                          "},
                new Hymn{ HymnID=109 , HymnTitle="The Lord My Pasture Will Prepare                 "},
                new Hymn{ HymnID=110 , HymnTitle="Cast Thy Burden upon the Lord                    "},
                new Hymn{ HymnID=111 , HymnTitle="Rock of Ages                                     "},
                new Hymn{ HymnID=112 , HymnTitle="Savior, Redeemer of My Soul                      "},
                new Hymn{ HymnID=113 , HymnTitle="Our Savior's Love                                "},
                new Hymn{ HymnID=114 , HymnTitle="Come unto Him                                    "},
                new Hymn{ HymnID=115 , HymnTitle="Come, Ye Disconsolate                            "},
                new Hymn{ HymnID=116 , HymnTitle="Come, Follow Me                                  "},
                new Hymn{ HymnID=117 , HymnTitle="Come unto Jesus                                  "},
                new Hymn{ HymnID=118 , HymnTitle="Ye Simple Souls Who Stray                        "},
                new Hymn{ HymnID=119 , HymnTitle="Come, We That Love the Lord                      "},
                new Hymn{ HymnID=120 , HymnTitle="Lean on My Ample Arm                             "},
                new Hymn{ HymnID=121 , HymnTitle="I’m a Pilgrim, I’m a Stranger                    "},
                new Hymn{ HymnID=122 , HymnTitle="Though Deepening Trials                          "},
                new Hymn{ HymnID=123 , HymnTitle="Oh, May My Soul Commune with Thee                "},
                new Hymn{ HymnID=124 , HymnTitle="Be Still, My Soul                                "},
                new Hymn{ HymnID=125 , HymnTitle="How Gentle God's Commands                        "},
                new Hymn{ HymnID=126 , HymnTitle="How Long, O Lord Most Holy and True              "},
                new Hymn{ HymnID=127 , HymnTitle="Does the Journey Seem Long?                      "},
                new Hymn{ HymnID=128 , HymnTitle="When Faith Endures                               "},
                new Hymn{ HymnID=129 , HymnTitle="Where Can I Turn for Peace?                      "},
                new Hymn{ HymnID=130 , HymnTitle="Be Thou Humble                                   "},
                new Hymn{ HymnID=131 , HymnTitle="More Holiness Give Me                            "},
                new Hymn{ HymnID=132 , HymnTitle="God Is in His Holy Temple                        "},
                new Hymn{ HymnID=133 , HymnTitle="Father in Heaven                                 "},
                new Hymn{ HymnID=134 , HymnTitle="I Believe in Christ                              "},
                new Hymn{ HymnID=135 , HymnTitle="My Redeemer Lives                                "},
                new Hymn{ HymnID=136 , HymnTitle="I Know That My Redeemer Lives                    "},
                new Hymn{ HymnID=137 , HymnTitle="Testimony                                        "},
                new Hymn{ HymnID=138 , HymnTitle="Bless Our Fast, We Pray                          "},
                new Hymn{ HymnID=139 , HymnTitle="In Fasting We Approach Thee                      "},
                new Hymn{ HymnID=140 , HymnTitle="Did You Think to Pray?                           "},
                new Hymn{ HymnID=141 , HymnTitle="Jesus, the Very Thought of Thee                  "},
                new Hymn{ HymnID=142 , HymnTitle="Sweet Hour of Prayer                             "},
                new Hymn{ HymnID=143 , HymnTitle="Let the Holy Spirit Guide                        "},
                new Hymn{ HymnID=144 , HymnTitle="Secret Prayer                                    "},
                new Hymn{ HymnID=145 , HymnTitle="Prayer Is the Soul’s Sincere Desire              "},
                new Hymn{ HymnID=146 , HymnTitle="Gently Raise the Sacred Strain                   "},
                new Hymn{ HymnID=147 , HymnTitle="Sweet Is the Work                                "},
                new Hymn{ HymnID=148 , HymnTitle="Sabbath Day                                      "},
                new Hymn{ HymnID=149 , HymnTitle="As the Dew from Heaven Distilling                "},
                new Hymn{ HymnID=150 , HymnTitle="O Thou Kind and Gracious Father                  "},
                new Hymn{ HymnID=151 , HymnTitle="We Meet, Dear Lord                               "},
                new Hymn{ HymnID=152 , HymnTitle="God Be with You Till We Meet Again               "},
                new Hymn{ HymnID=153 , HymnTitle="Lord, We Ask Thee Ere We Part                    "},
                new Hymn{ HymnID=154 , HymnTitle="Father, This Hour Has Been One of Joy            "},
                new Hymn{ HymnID=155 , HymnTitle="We Have Partaken of Thy Love                     "},
                new Hymn{ HymnID=156 , HymnTitle="Sing We Now at Parting                           "},
                new Hymn{ HymnID=157 , HymnTitle="Thy Spirit, Lord, Has Stirred Our Souls          "},
                new Hymn{ HymnID=158 , HymnTitle="Before Thee, Lord, I Bow My Head                 "},
                new Hymn{ HymnID=159 , HymnTitle="Now the Day Is Over                              "},
                new Hymn{ HymnID=160 , HymnTitle="Softly Now the Light of Day                      "},
                new Hymn{ HymnID=161 , HymnTitle="The Lord Be with Us                              "},
                new Hymn{ HymnID=162 , HymnTitle="Lord, We Come before Thee Now                    "},
                new Hymn{ HymnID=163 , HymnTitle="Lord, Dismiss Us with Thy Blessing               "},
                new Hymn{ HymnID=164 , HymnTitle="Great God, to Thee My Evening Song               "},
                new Hymn{ HymnID=165 , HymnTitle="Abide with Me; 'Tis Eventide                     "},
                new Hymn{ HymnID=166 , HymnTitle="Abide with Me!                                   "},
                new Hymn{ HymnID=167 , HymnTitle="Come, Let Us Sing an Evening Hymn                "},
                new Hymn{ HymnID=168 , HymnTitle="As the Shadows Fall                              "},
                new Hymn{ HymnID=169 , HymnTitle="As Now We Take the Sacrament                     "},
                new Hymn{ HymnID=170 , HymnTitle="God, Our Father, Hear Us Pray                    "},
                new Hymn{ HymnID=171 , HymnTitle="With Humble Heart                                "},
                new Hymn{ HymnID=172 , HymnTitle="In Humility, Our Savior                          "},
                new Hymn{ HymnID=173 , HymnTitle="While of These Emblems We Partake                "},
                new Hymn{ HymnID=174 , HymnTitle="While of These Emblems We Partake                "},
                new Hymn{ HymnID=175 , HymnTitle="O God, the Eternal Father                        "},
                new Hymn{ HymnID=176 , HymnTitle="’Tis Sweet to Sing the Matchless Love            "},
                new Hymn{ HymnID=177 , HymnTitle="’Tis Sweet to Sing the Matchless Love            "},
                new Hymn{ HymnID=178 , HymnTitle="O Lord of Hosts                                  "},
                new Hymn{ HymnID=179 , HymnTitle="Again, Our Dear Redeeming Lord                   "},
                new Hymn{ HymnID=180 , HymnTitle="Father in Heaven, We Do Believe                  "},
                new Hymn{ HymnID=181 , HymnTitle="Jesus of Nazareth, Savior and King               "},
                new Hymn{ HymnID=182 , HymnTitle="We’ll Sing All Hail to Jesus’ Name               "},
                new Hymn{ HymnID=183 , HymnTitle="In Remembrance of Thy Suffering                  "},
                new Hymn{ HymnID=184 , HymnTitle="Upon the Cross of Calvary                        "},
                new Hymn{ HymnID=185 , HymnTitle="Reverently and Meekly Now                        "},
                new Hymn{ HymnID=186 , HymnTitle="Again We Meet around the Board                   "},
                new Hymn{ HymnID=187 , HymnTitle="God Loved Us, So He Sent His Son                 "},
                new Hymn{ HymnID=188 , HymnTitle="Thy Will, O Lord, Be Done                        "},
                new Hymn{ HymnID=189 , HymnTitle="O Thou, Before the World Began                   "},
                new Hymn{ HymnID=190 , HymnTitle="In Memory of the Crucified                       "},
                new Hymn{ HymnID=191 , HymnTitle="Behold the Great Redeemer Die                    "},
                new Hymn{ HymnID=192 , HymnTitle="He Died! The Great Redeemer Died                 "},
                new Hymn{ HymnID=193 , HymnTitle="I Stand All Amazed                               "},
                new Hymn{ HymnID=194 , HymnTitle="There Is a Green Hill Far Away                   "},
                new Hymn{ HymnID=195 , HymnTitle="How Great the Wisdom and the Love                "},
                new Hymn{ HymnID=196 , HymnTitle="Jesus, Once of Humble Birth                      "},
                new Hymn{ HymnID=197 , HymnTitle="O Savior, Thou Who Wearest a Crown               "},
                new Hymn{ HymnID=198 , HymnTitle="That Easter Morn                                 "},
                new Hymn{ HymnID=199 , HymnTitle="He Is Risen!                                     "},
                new Hymn{ HymnID=200 , HymnTitle="Christ the Lord Is Risen Today                   "},
                new Hymn{ HymnID=201 , HymnTitle="Joy to the World                                 "},
                new Hymn{ HymnID=202 , HymnTitle="Oh, Come, All Ye Faithful                        "},
                new Hymn{ HymnID=203 , HymnTitle="Angels We Have Heard on High                     "},
                new Hymn{ HymnID=204 , HymnTitle="Silent Night                                     "},
                new Hymn{ HymnID=205 , HymnTitle="Once in Royal David's City                       "},
                new Hymn{ HymnID=206 , HymnTitle="Away in a Manger                                 "},
                new Hymn{ HymnID=207 , HymnTitle="It Came upon the Midnight Clear                  "},
                new Hymn{ HymnID=208 , HymnTitle="O Little Town of Bethlehem                       "},
                new Hymn{ HymnID=209 , HymnTitle="Hark! The Herald Angels Sing                     "},
                new Hymn{ HymnID=210 , HymnTitle="With Wondering Awe                               "},
                new Hymn{ HymnID=211 , HymnTitle="While Shepherds Watched Their Flocks             "},
                new Hymn{ HymnID=212 , HymnTitle="Far, Far Away on Judea's Plains                  "},
                new Hymn{ HymnID=213 , HymnTitle="The First Noel                                   "},
                new Hymn{ HymnID=214 , HymnTitle="I Heard the Bells on Christmas Day               "},
                new Hymn{ HymnID=215 , HymnTitle="Ring Out, Wild Bells                             "},
                new Hymn{ HymnID=216 , HymnTitle="We Are Sowing                                    "},
                new Hymn{ HymnID=217 , HymnTitle="Come, Let Us Anew                                "},
                new Hymn{ HymnID=218 , HymnTitle="We Give Thee But Thine Own                       "},
                new Hymn{ HymnID=219 , HymnTitle="Because I Have Been Given Much                   "},
                new Hymn{ HymnID=220 , HymnTitle="Lord, I Would Follow Thee                        "},
                new Hymn{ HymnID=221 , HymnTitle="Dear to the Heart of the Shepherd                "},
                new Hymn{ HymnID=222 , HymnTitle="Hear Thou Our Hymn, O Lord                       "},
                new Hymn{ HymnID=223 , HymnTitle="Have I Done Any Good?                            "},
                new Hymn{ HymnID=224 , HymnTitle="I Have Work Enough to Do                         "},
                new Hymn{ HymnID=225 , HymnTitle="We Are Marching On to Glory                      "},
                new Hymn{ HymnID=226 , HymnTitle="Improve the Shining Moments                      "},
                new Hymn{ HymnID=227 , HymnTitle="There Is Sunshine in My Soul Today               "},
                new Hymn{ HymnID=228 , HymnTitle="You Can Make the Pathway Bright                  "},
                new Hymn{ HymnID=229 , HymnTitle="Today, While the Sun Shines                      "},
                new Hymn{ HymnID=230 , HymnTitle="Scatter Sunshine                                 "},
                new Hymn{ HymnID=231 , HymnTitle="Father, Cheer Our Souls Tonight                  "},
                new Hymn{ HymnID=232 , HymnTitle="Let Us Oft Speak Kind Words                      "},
                new Hymn{ HymnID=233 , HymnTitle="Nay, Speak No Ill                                "},
                new Hymn{ HymnID=234 , HymnTitle="Jesus, Mighty King in Zion                       "},
                new Hymn{ HymnID=235 , HymnTitle="Should You Feel Inclined to Censure              "},
                new Hymn{ HymnID=236 , HymnTitle="Lord, Accept into Thy Kingdom                    "},
                new Hymn{ HymnID=237 , HymnTitle="Do What Is Right                                 "},
                new Hymn{ HymnID=238 , HymnTitle="Behold Thy Sons and Daughters, Lord              "},
                new Hymn{ HymnID=239 , HymnTitle="Choose the Right                                 "},
                new Hymn{ HymnID=240 , HymnTitle="Know This, That Every Soul Is Free               "},
                new Hymn{ HymnID=241 , HymnTitle="Count Your Blessings                             "},
                new Hymn{ HymnID=242 , HymnTitle="Praise God, from Whom All Blessings Flow         "},
                new Hymn{ HymnID=243 , HymnTitle="Let Us All Press On                              "},
                new Hymn{ HymnID=244 , HymnTitle="Come Along, Come Along                           "},
                new Hymn{ HymnID=245 , HymnTitle="This House We Dedicate to Thee                   "},
                new Hymn{ HymnID=246 , HymnTitle="Onward, Christian Soldiers                       "},
                new Hymn{ HymnID=247 , HymnTitle="We Love Thy House, O God                         "},
                new Hymn{ HymnID=248 , HymnTitle="Up, Awake, Ye Defenders of Zion                  "},
                new Hymn{ HymnID=249 , HymnTitle="Called to Serve                                  "},
                new Hymn{ HymnID=250 , HymnTitle="We Are All Enlisted                              "},
                new Hymn{ HymnID=251 , HymnTitle="Behold! A Royal Army                             "},
                new Hymn{ HymnID=252 , HymnTitle="Put Your Shoulder to the Wheel                   "},
                new Hymn{ HymnID=253 , HymnTitle="Like Ten Thousand Legions Marching               "},
                new Hymn{ HymnID=254 , HymnTitle="True to the Faith                                "},
                new Hymn{ HymnID=255 , HymnTitle="Carry On                                         "},
                new Hymn{ HymnID=256 , HymnTitle="As Zion's Youth in Latter Days                   "},
                new Hymn{ HymnID=257 , HymnTitle="Rejoice! A Glorious Sound Is Heard               "},
                new Hymn{ HymnID=258 , HymnTitle="O Thou Rock of Our Salvation                     "},
                new Hymn{ HymnID=259 , HymnTitle="Hope of Israel                                   "},
                new Hymn{ HymnID=260 , HymnTitle="Who's on the Lord's Side?                        "},
                new Hymn{ HymnID=261 , HymnTitle="Thy Servants Are Prepared                        "},
                new Hymn{ HymnID=262 , HymnTitle="Go, Ye Messengers of Glory                       "},
                new Hymn{ HymnID=263 , HymnTitle="Go Forth with Faith                              "},
                new Hymn{ HymnID=264 , HymnTitle="Hark, All Ye Nations!                            "},
                new Hymn{ HymnID=265 , HymnTitle="Arise, O God, and Shine                          "},
                new Hymn{ HymnID=266 , HymnTitle="The Time Is Far Spent                            "},
                new Hymn{ HymnID=267 , HymnTitle="How Wondrous and Great                           "},
                new Hymn{ HymnID=268 , HymnTitle="Come, All Whose Souls Are Lighted                "},
                new Hymn{ HymnID=269 , HymnTitle="Jehovah, Lord of Heaven and Earth                "},
                new Hymn{ HymnID=270 , HymnTitle="I'll Go Where You Want Me to Go                  "},
                new Hymn{ HymnID=271 , HymnTitle="Oh, Holy Words of Truth and Love                 "},
                new Hymn{ HymnID=272 , HymnTitle="Oh Say, What Is Truth?                           "},
                new Hymn{ HymnID=273 , HymnTitle="Truth Reflects upon Our Senses                   "},
                new Hymn{ HymnID=274 , HymnTitle="The Iron Rod                                     "},
                new Hymn{ HymnID=275 , HymnTitle="Men Are That They Might Have Joy                 "},
                new Hymn{ HymnID=276 , HymnTitle="Come Away to the Sunday School                   "},
                new Hymn{ HymnID=277 , HymnTitle="As I Search the Holy Scriptures                  "},
                new Hymn{ HymnID=278 , HymnTitle="Thanks for the Sabbath School                    "},
                new Hymn{ HymnID=279 , HymnTitle="Thy Holy Word                                    "},
                new Hymn{ HymnID=280 , HymnTitle="Welcome, Welcome, Sabbath Morning                "},
                new Hymn{ HymnID=281 , HymnTitle="Help Me Teach with Inspiration                   "},
                new Hymn{ HymnID=282 , HymnTitle="We Meet Again in Sabbath School                  "},
                new Hymn{ HymnID=283 , HymnTitle="The Glorious Gospel Light Has Shone              "},
                new Hymn{ HymnID=284 , HymnTitle="If You Could Hie to Kolob                        "},
                new Hymn{ HymnID=285 , HymnTitle="God Moves in a Mysterious Way                    "},
                new Hymn{ HymnID=286 , HymnTitle="Oh, What Songs of the Heart                      "},
                new Hymn{ HymnID=287 , HymnTitle="Rise, Ye Saints, and Temples Enter               "},
                new Hymn{ HymnID=288 , HymnTitle="How Beautiful Thy Temples, Lord                  "},
                new Hymn{ HymnID=289 , HymnTitle="Holy Temples on Mount Zion                       "},
                new Hymn{ HymnID=290 , HymnTitle="Rejoice, Ye Saints of Latter Days                "},
                new Hymn{ HymnID=291 , HymnTitle="Turn Your Hearts                                 "},
                new Hymn{ HymnID=292 , HymnTitle="O My Father                                      "},
                new Hymn{ HymnID=293 , HymnTitle="Each Life That Touches Ours for Good             "},
                new Hymn{ HymnID=294 , HymnTitle="Love at Home                                     "},
                new Hymn{ HymnID=295 , HymnTitle="O Love That Glorifies the Son                    "},
                new Hymn{ HymnID=296 , HymnTitle="Our Father, by Whose Name                        "},
                new Hymn{ HymnID=297 , HymnTitle="From Homes of Saints Glad Songs Arise            "},
                new Hymn{ HymnID=298 , HymnTitle="Home Can Be a Heaven on Earth                    "},
                new Hymn{ HymnID=299 , HymnTitle="Children of Our Heavenly Father                  "},
                new Hymn{ HymnID=300 , HymnTitle="Families Can Be Together Forever                 "},
                new Hymn{ HymnID=301 , HymnTitle="I Am a Child of God                              "},
                new Hymn{ HymnID=302 , HymnTitle="I Know My Father Lives                           "},
                new Hymn{ HymnID=303 , HymnTitle="Keep the Commandments                            "},
                new Hymn{ HymnID=304 , HymnTitle="Teach Me to Walk in the Light                    "},
                new Hymn{ HymnID=305 , HymnTitle="The Light Divine                                 "},
                new Hymn{ HymnID=306 , HymnTitle="God’s Daily Care                                 "},
                new Hymn{ HymnID=307 , HymnTitle="In Our Lovely Deseret                            "},
                new Hymn{ HymnID=308 , HymnTitle="Love One Another                                 "},
                new Hymn{ HymnID=309 , HymnTitle="As Sisters in Zion                               "},
                new Hymn{ HymnID=310 , HymnTitle="A Key Was Turned in Latter Days                  "},
                new Hymn{ HymnID=311 , HymnTitle="We Meet Again as Sisters                         "},
                new Hymn{ HymnID=312 , HymnTitle="We Ever Pray for Thee                            "},
                new Hymn{ HymnID=313 , HymnTitle="God Is Love                                      "},
                new Hymn{ HymnID=314 , HymnTitle="How Gentle God's Commands (Women)                "},
                new Hymn{ HymnID=315 , HymnTitle="Jesus, the Very Thought of Thee                  "},
                new Hymn{ HymnID=316 , HymnTitle="The Lord Is My Shepherd (Women)                  "},
                new Hymn{ HymnID=317 , HymnTitle="Sweet Is the Work (Women)                        "},
                new Hymn{ HymnID=318 , HymnTitle="Love at Home (Women)                             "},
                new Hymn{ HymnID=319 , HymnTitle="Ye Elders of Israel (Men)                        "},
                new Hymn{ HymnID=320 , HymnTitle="The Priesthood of Our Lord (Men)                 "},
                new Hymn{ HymnID=321 , HymnTitle="Ye Who Are Called to Labor                       "},
                new Hymn{ HymnID=322 , HymnTitle="Come, All Ye Sons of God (Men)                   "},
                new Hymn{ HymnID=323 , HymnTitle="Rise Up, O Men of God (Men's Choir)              "},
                new Hymn{ HymnID=324 , HymnTitle="Rise Up, O Men of God (Men)                      "},
                new Hymn{ HymnID=325 , HymnTitle="See the Mighty Priesthood Gathered (Men's Choir) "},
                new Hymn{ HymnID=326 , HymnTitle="Come, Come, Ye Saints                            "},
                new Hymn{ HymnID=327 , HymnTitle="Go, Ye Messengers of Heaven                      "},
                new Hymn{ HymnID=328 , HymnTitle="An Angel from on High                            "},
                new Hymn{ HymnID=329 , HymnTitle="Thy Servants Are Prepared                        "},
                new Hymn{ HymnID=330 , HymnTitle="See, the Mighty Angel Flying                     "},
                new Hymn{ HymnID=331 , HymnTitle="Oh Say, What Is Truth?                           "},
                new Hymn{ HymnID=332 , HymnTitle="Come, O Thou King of Kings                       "},
                new Hymn{ HymnID=333 , HymnTitle="High on the Mountain Top (Men's Choir)           "},
                new Hymn{ HymnID=334 , HymnTitle="I Need Thee Every Hour                           "},
                new Hymn{ HymnID=335 , HymnTitle="Brightly Beams Our Father's Mercy (Men's Choir)  "},
                new Hymn{ HymnID=336 , HymnTitle="School Thy Feelings (Men's Choir)                "},
                new Hymn{ HymnID=337 , HymnTitle="O Home Beloved (Men's Choir)                     "},
                new Hymn{ HymnID=338 , HymnTitle="America the Beautiful                            "},
                new Hymn{ HymnID=339 , HymnTitle="My Country, 'Tis of Thee                         "},
                new Hymn{ HymnID=340 , HymnTitle="The Star-Spangled Banner                         "},
                new Hymn{ HymnID=341 , HymnTitle="God Save the King                                "},
            };

            foreach (Hymn b in hymns)
            {
                context.Hymns.Add(b);
            }

            context.SaveChanges();
        }
    }
}
